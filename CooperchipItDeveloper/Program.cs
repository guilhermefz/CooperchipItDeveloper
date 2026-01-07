using AspNetCoreHero.ToastNotification;
using AspNetCoreHero.ToastNotification.Extensions;
using Cooperchip.ItDeveloper.Data.Data.ORM;
using Cooperchip.ItDeveloper.Mvc.Mappers;
using Cooperchip.ITDeveloper.Application.Areas.Pacientes.Services;
using Cooperchip.ITDeveloper.Application.Areas.Pacientes.Validators;
using CooperchipItDeveloper.Mvc.Configuration;
using CooperchipItDeveloper.Mvc.Data;
using CooperchipItDeveloper.Mvc.Extensions;
using CooperchipItDeveloper.Mvc.Extensions.ExtensionsMethods;
using CooperchipItDeveloper.Mvc.Services;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace CooperchipItDeveloper
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddNotyf(config => {
                config.DurationInSeconds = 3;
                config.IsDismissable = true;
                config.Position = NotyfPosition.TopCenter;
                config.HasRippleEffect = false;
            });

            builder.Services.AddControllersWithViews();
            builder.Services.AddValidatorsFromAssemblyContaining<PacienteValidator>();
            builder.Services.AddAutoMapper(typeof(PacienteMapper));

            builder.Services.AddDbContext<ITDeveloperDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CooperchipItDeveloper.Mvc;Trusted_Connection=True;MultipleActiveResultSets=true"));

            builder.Services.AdicionarProvedorDeLogs(builder.Configuration);

            builder.Services.AddIddentityConfig(builder.Configuration);

            builder.Services.AddDefaultIdentity<ApplicationUser>(options => {
                // User
                options.User.RequireUniqueEmail = true;
                options.User.AllowedUserNameCharacters =
                    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";

                // Lockout
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(4);
                options.Lockout.MaxFailedAccessAttempts = 4;
                options.Lockout.AllowedForNewUsers = true;

                // SignIn
                options.SignIn.RequireConfirmedPhoneNumber = false;
                options.SignIn.RequireConfirmedAccount = false;
                options.SignIn.RequireConfirmedEmail = false;

                // Password
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 8;
                options.Password.RequiredUniqueChars = 2;
            })
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<ApplicationDbContext>();

            builder.Services.AddScoped<PacienteService>();
            builder.Services.AddScoped<EstadoPacienteService>();
            builder.Services.AddDependencyInjectConfig(builder.Configuration);

            //fornece acesso a um provedor de codificação para páginas de código que, de outra forma,
            //estão disponíveis apenas no .Net Framework para Desktop
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.MapRazorPages();
            app.UseNotyf();

            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<ApplicationDbContext>();
                var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
                var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

               //await CriaUsersAndRoles.Seed(context, userManager, roleManager);
            }
            
            


            app.Run();
        }
    }
}
