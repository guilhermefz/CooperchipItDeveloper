using Cooperchip.ITDeveloper.CrossCutting.Helpers;
using CooperchipItDeveloper.Domain.Interfaces;
using CooperchipItDeveloper.Mvc.Extensions.Services;
using CooperchipItDeveloper.Mvc.Intra;

namespace CooperchipItDeveloper.Mvc.Configuration
{
    public static class DependencyInjectConfig
    {
        public static IServiceCollection AddDependencyInjectConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IUnitOfUpload, UnitOfUpload>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddScoped<IUserInContext<Guid>, AspNetUser>();

            return services;
        }
    }
}
