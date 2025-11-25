using CooperchipItDeveloper.Mvc.Extensions.Services;
using CooperchipItDeveloper.Mvc.Intra;

namespace CooperchipItDeveloper.Mvc.Configuration
{
    public static class DependencyInjectConfig
    {
        public static IServiceCollection AddDependencyInjectConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IUnitOfUpload, UnitOfUpload>();

            return services;
        }
    }
}
