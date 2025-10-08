using CooperchipItDeveloper.Mvc.Data;
using CooperchipItDeveloper.Mvc.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CooperchipItDeveloper.Mvc.Security.Services
{
    public static class DefaultUsersAndRoles
    {
        public static async Task Seed(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleMenager)
        {
            const string nomeCompleto = "Anderson Silva";
            const string apelido = "Spider";
            var datanascimento = DateTime.Now;
            const string email = "spider@gmail.com";
            const string password = "Admin@123";
            const string roleName = "Admin";
            const string username = email;

            context.Database.Migrate();
            if (await roleMenager.FindByNameAsync(roleName) == null)
            {
                await roleMenager.CreateAsync(new IdentityRole(roleName));
            }

            if (await userManager.FindByNameAsync(username) == null)
            {
                var user = new ApplicationUser
                {
                    Apelido = apelido,
                    Email = email,
                    NomeCompleto = nomeCompleto,
                    DataNascimento = datanascimento,
                    UserName = username,
                    PhoneNumber = "49987765432",
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, roleName);
                }
            }
        }
    }
}
