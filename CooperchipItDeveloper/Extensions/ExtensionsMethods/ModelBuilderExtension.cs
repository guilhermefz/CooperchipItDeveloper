using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CooperchipItDeveloper.Mvc.Extensions.ExtensionsMethods
{
    public static class ModelBuilderExtension
    {
        const string NOMECOMPLETO = "Charles Oliveira";
        const string APELIDO = "Charles do Bronx";
        //DateTime datanascimento = DateTime.Now;
        const string EMAIL = "iluminado@gmail.com";
        const string PASSWORD = "Admin@123";
        const string ROLERNAME = "Admin";
        const string USERNAME = EMAIL;
        const string ROLEID = "F58EB8E9-4BD4-4398-A7BC-F76F9CB0F021";
        const string USERID = "38D1B050-7F27-4563-903A-277E480B548D";

        public static ModelBuilder AddUserAndRole (this ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Id = ROLEID,
                Name = ROLERNAME,
                NormalizedName = ROLERNAME.ToUpper()
            }
        );

            var passwordHash = new PasswordHasher<ApplicationUser>();

            builder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = USERID,
                    Apelido = APELIDO,
                    NomeCompleto = NOMECOMPLETO,
                    DataNascimento = DateTime.Now,
                    Email = EMAIL,
                    NormalizedEmail = EMAIL.ToUpper(),
                    UserName = USERNAME,
                    NormalizedUserName = USERNAME.ToUpper(),
                    PasswordHash = passwordHash.HashPassword(null, PASSWORD),
                    EmailConfirmed = true,
                });

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = ROLEID,
                    UserId = USERID,
                });

            return builder;
        }
    }
}
