using AspNetCoreHero.ToastNotification;
using AspNetCoreHero.ToastNotification.Extensions;
using AutoMapper;
using Cooperchip.ItDeveloper.Data.Data.ORM;
using Cooperchip.ItDeveloper.Mvc.Mappers;
using Cooperchip.ItDeveloper.Mvc.Services;
using CooperchipItDeveloper.Mvc.Data;
using CooperchipItDeveloper.Mvc.Extensions;
using CooperchipItDeveloper.Mvc.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CooperchipItDeveloper
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddNotyf(config => {
                config.DurationInSeconds = 3;
                config.IsDismissable = true;
                config.Position = NotyfPosition.TopCenter;
                config.HasRippleEffect = false;
            });

            builder.Services.AddControllersWithViews();
            builder.Services.AddAutoMapper(typeof(PacienteMapper));

            builder.Services.AddDbContext<ITDeveloperDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddDbContext<ApplicationDbContext>(
                options => options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CooperchipItDeveloper.Mvc;Trusted_Connection=True;MultipleActiveResultSets=true"));

            builder.Services.AddDefaultIdentity<ApplicationUser>(options => {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 6;
            }).AddEntityFrameworkStores<ApplicationDbContext>();

            builder.Services.AddScoped<PacienteService>();
            builder.Services.AddScoped<EstadoPacienteService>();

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            
            app.MapRazorPages();
            app.UseNotyf();

            app.Run();
        }
    }
}


