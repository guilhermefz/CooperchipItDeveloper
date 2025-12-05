using Cooperchip.ITDeveloper.CrossCutting.Helpers;
using Cooperchip.ITDeveloper.Repository.Entidade;
using CooperchipItDeveloper.Domain.Interfaces;
using CooperchipItDeveloper.Domain.Interfaces.Entidades;
using CooperchipItDeveloper.Mvc.Extensions;
using CooperchipItDeveloper.Mvc.Extensions.Services;
using CooperchipItDeveloper.Mvc.Intra;
using Microsoft.AspNetCore.Identity;

namespace CooperchipItDeveloper.Mvc.Configuration
{
    public static class DependencyInjectConfig
    {
        public static IServiceCollection AddDependencyInjectConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IUnitOfUpload, UnitOfUpload>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddScoped<IUserInContext, AspNetUser>();

            services.AddScoped<IUserClaimsPrincipalFactory<ApplicationUser>, UserClaimsService>();

            services.AddScoped<IRepositoryDomainPaciente, PacienteRepository>();

            return services;
        }
    }
}
