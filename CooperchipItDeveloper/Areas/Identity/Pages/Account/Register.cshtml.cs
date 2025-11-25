// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using AspNetCoreHero.ToastNotification.Abstractions;
using CooperchipItDeveloper.Mvc.Extensions;
using CooperchipItDeveloper.Mvc.Intra;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Encodings.Web;

namespace CooperchipItDeveloper.Mvc.Areas.Identity.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private readonly IUnitOfUpload _unitOfUpload;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserStore<ApplicationUser> _userStore;
        private readonly IUserEmailStore<ApplicationUser> _emailStore;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly INotyfService _notyf;

        public RegisterModel(
            UserManager<ApplicationUser> userManager,
            IUserStore<ApplicationUser> userStore,
            SignInManager<ApplicationUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            INotyfService notyf,
            IUnitOfUpload unitOfUpload)
        {
            _userManager = userManager;
            _userStore = userStore;
            _emailStore = GetEmailStore();
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _notyf = notyf;
            _unitOfUpload = unitOfUpload;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "O campo {0} é obrigatório.")]
            [EmailAddress(ErrorMessage = "Digite um email válido")]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required(ErrorMessage = "O campo {0} é obrigatório.")]
            [StringLength(100, ErrorMessage = "O campo {0} deve conter entre {2} e {1} caracteres.", MinimumLength = 8)]
            [DataType(DataType.Password)]
            [Display(Name = "Senha")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirmar senha")]
            [Compare("Password", ErrorMessage = "As duas senhas não são idênticas.")]
            public string ConfirmPassword { get; set; }



            [PersonalData]
            [Required(ErrorMessage = "O campo {0} é obrigatório!")]
            [StringLength(maximumLength: 35, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
            public string Apelido { get; set; }

            [PersonalData]
            [Required(ErrorMessage = "O campo {0} é obrigatório!")]
            [StringLength(maximumLength: 35, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
            [Display(Name = "Nome Completo")]
            public string NomeCompleto { get; set; }

            [PersonalData]
            [Required(ErrorMessage = "O campo {0} é obrigatório!")]
            [Display(Name = "Data de Nascimento")]
            public DateTime DataNascimento { get; set; }

            [ProtectedPersonalData]
            [DataType(DataType.Text)]
            [StringLength(maximumLength: 255, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 21)]
            public string? imgProfilePath { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(IFormFile file, string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                if(!(file == null || string.IsNullOrEmpty(file.FileName))) 
                    _unitOfUpload.UploadImage(file);

                var user = CreateUser();


                user.NomeCompleto = Input.NomeCompleto;
                user.Apelido = Input.Apelido;
                user.DataNascimento = Input.DataNascimento;
                user.imgProfilePath = file != null ? file.FileName : "";

                await _userStore.SetUserNameAsync(user, Input.Email, CancellationToken.None);
                await _emailStore.SetEmailAsync(user, Input.Email, CancellationToken.None);
                user.Apelido = Input.Apelido;
                var result = await _userManager.CreateAsync((ApplicationUser)user, Input.Password);

                if (result.Succeeded)
                {
                    _logger.LogInformation("Uma nova conta de usuario foi criada.");

                    var userId = await _userManager.GetUserIdAsync((ApplicationUser)user);
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync((ApplicationUser)user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = userId, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirme seu email",
                        $"Por favor confirme sua conta por <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clique aqui</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("Confirmação de registro", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync((ApplicationUser)user, isPersistent: false);
                        return RedirectToAction("Index", "Home");
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }

        private ApplicationUser CreateUser()
        {
            try
            {
                return Activator.CreateInstance<ApplicationUser>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(ApplicationUser)}'. " +
                    $"Ensure that '{nameof(ApplicationUser)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }

        private IUserEmailStore<ApplicationUser> GetEmailStore()
        {
            if (!_userManager.SupportsUserEmail)
            {
                throw new NotSupportedException("The default UI requires a user store with email support.");
            }
            return (IUserEmailStore<ApplicationUser>)_userStore;
        }
    }
}
