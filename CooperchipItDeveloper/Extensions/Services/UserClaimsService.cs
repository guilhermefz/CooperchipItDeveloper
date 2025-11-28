using CooperchipItDeveloper.Mvc.Data;
using CooperchipItDeveloper.Mvc.Extensions.ExtensionsMethods;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Configuration;
using System.Security.Claims;

namespace CooperchipItDeveloper.Mvc.Extensions.Services
{
    public class UserClaimsService : UserClaimsPrincipalFactory<ApplicationUser, IdentityRole>
    {
        private readonly ApplicationDbContext _context;

        public UserClaimsService(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IOptions<IdentityOptions> aoptionsAccessor) : base(userManager, roleManager, aoptionsAccessor)
        {
            _context = context;
        }

        public async override Task<ClaimsPrincipal> CreateAsync(ApplicationUser user)
        {
            var principal = await base.CreateAsync(user);
            //todo: Aqui podemos pegar as Claims do User no Bnaco de dados
            //...
            //AddClaims

            ((ClaimsIdentity)principal.Identity).AddClaims(new[]
            {
                new Claim("Apelido", user.Apelido),
                new Claim("Nome Completo", user.NomeCompleto),
                new Claim("Email", user.Email),
                new Claim("DataNascimento", user.DataNascimento.ToBrazilianDate()),
                new Claim("ImgProfilePath", !string.IsNullOrEmpty(user.imgProfilePath) ? user.imgProfilePath: "")
            });
            return principal;
        }
    }
}
