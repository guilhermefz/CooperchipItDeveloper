using CooperchipItDeveloper.Mvc.Extensions;
using CooperchipItDeveloper.Mvc.Extensions.ExtensionsMethods;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CooperchipItDeveloper.Mvc.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    //const string NOMECOMPLETO = "Alex Pereira";
    //const string APELIDO = "Poatan";
    //DateTime DATANASCIMENTO = DateTime.Now;
    //const string EMAIL = "poatan@gmail.com";
    //const string PASSWORD = "Admin@123";
    //const string ROLERNAME = "Convidado";
    //const string USERNAME = EMAIL;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }


    //const string ROLEID = " F58EB8E9 - 4BD4 - 4398 - A7BC - F76F9CB0F1E0 ";
    //const string USERID = "38D1B050-7F27-4563-903A-277E480B5580";

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        ModelBuilderExtension.AddUserAndRole(builder);
        //builder.Entity<IdentityRole>().HasData(
        //    new IdentityRole
        //    {
        //        Id = ROLEID,
        //        Name = ROLERNAME,
        //        NormalizedName = ROLEID.ToUpper()
        //    }
        //);

        //var passwordHash = new PasswordHasher<ApplicationUser>();

        //builder.Entity<ApplicationUser>().HasData(
        //    new ApplicationUser
        //    {
        //        Id = USERID,
        //        Apelido = APELIDO,
        //        NomeCompleto = NOMECOMPLETO,
        //        DataNascimento = DATANASCIMENTO,
        //        Email = EMAIL,
        //        NormalizedEmail = EMAIL.ToUpper(),
        //        UserName = USERNAME,
        //        NormalizedUserName = USERNAME.ToUpper(),
        //        PasswordHash = passwordHash.HashPassword(null, PASSWORD),
        //        EmailConfirmed = true,
        //    });

        //builder.Entity<IdentityUserRole<string>>().HasData(
        //    new IdentityUserRole<string>
        //    {
        //        RoleId = ROLEID,
        //        UserId = USERID,
        //    });

        //base.OnModelCreating(builder);

        builder.Entity<IdentityUserLogin<string>>().HasKey(p => new { p.LoginProvider, p.ProviderKey });

        builder.Entity<IdentityUserToken<string>>().HasKey(p => new { p.UserId, p.LoginProvider, p.Name });
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
