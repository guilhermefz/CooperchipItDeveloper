using CooperchipItDeveloper.Mvc.Data;
using CooperchipItDeveloper.Mvc.Security.Services;
using Microsoft.AspNetCore.Identity;
using System.Diagnostics;
using Microsoft.AspNetCore.Http; // Adicionado para garantir HttpContext

namespace CooperchipItDeveloper.Mvc.Extensions.Middlewares
{
    public class DefaultUsersAndRolesMiddleware
    {
        private readonly RequestDelegate _next;

        public DefaultUsersAndRolesMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(
            HttpContext _ctx,
            ApplicationDbContext dbContext,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            Debug.WriteLine("Rodando o processo de verificação de usuário e papeis existentes. Se não houver criar!");

            CriaUsersAndRoles.Seed(dbContext, userManager, roleManager).Wait();

            await _next(_ctx);

            Debug.WriteLine("Processo de verificação de usuário e papeis terminado!");
        }
    }
}