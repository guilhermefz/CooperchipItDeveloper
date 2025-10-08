// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using CooperchipItDeveloper.Mvc.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CooperchipItDeveloper.Mvc.Areas.Identity.Pages.Account.Manage
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public IndexModel( UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public string Username { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Phone]
            [Display(Name = "Phone number")]
            public string PhoneNumber { get; set; }

            [Required]
            [Display(Name = "Nome Completo")]
            public string NomeCompleto { get; set; }

            [Display(Name = "Apelido")]
            public string Apelido {  get; set; }

            [DataType(DataType.Date)]
            [DisplayName("Data de Nascimento")]
            public DateTime DataNascimento { get; set; }

        }

        private async Task LoadAsync(ApplicationUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);

            var nomeCompleto = user.NomeCompleto;
            var apelido = user.Apelido;
            var dataNascimento = user.DataNascimento;

            Username = userName;

            Input = new InputModel
            {
                PhoneNumber = phoneNumber,
                NomeCompleto = nomeCompleto,
                Apelido = apelido,
                DataNascimento = dataNascimento
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    StatusMessage = "Unexpected error when trying to set phone number.";
                    return RedirectToPage();
                }
            }

            bool profileUpdated = false;
            if (Input.Apelido != user.NomeCompleto)
            {
                user.NomeCompleto = Input.NomeCompleto;
                profileUpdated = true;
            }

            if(Input.Apelido != user.Apelido)
            {
                user.Apelido = Input.Apelido;
                profileUpdated = true;
            }

            if (Input.DataNascimento != user.DataNascimento) 
            {
                user.DataNascimento = Input.DataNascimento;
                profileUpdated = true;
            }

            if (profileUpdated)
            {
                var updateResult = await _userManager.UpdateAsync(user);
                if(!updateResult.Succeeded)
                {
                    StatusMessage = "Erro inesperado na tentativa de atualizar o perfil.";
                    return RedirectToPage();
                }
            }

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}
