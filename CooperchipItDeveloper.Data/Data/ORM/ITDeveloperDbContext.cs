using Cooperchip.ItDeveloper.Domain.Entities;
using CooperchipItDeveloper.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Cooperchip.ItDeveloper.Data.Data.ORM
{
    public class ITDeveloperDbContext : DbContext
    {
        public ITDeveloperDbContext(DbContextOptions<ITDeveloperDbContext> options) : base(options)
        { }

        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<EstadoPaciente> EstadoPaciente { get; set; }
        public DbSet<Generico> Genericos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
            {
                property.SetColumnType("varchar(90)");
            }

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ITDeveloperDbContext).Assembly);

            modelBuilder.AddGenericos();

            foreach (var relationship in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;
            }

            base.OnModelCreating(modelBuilder);
        }
    }


    public static class ModelBuilderExtensions
    {
        public static ModelBuilder AddGenericos(this ModelBuilder builder)
        {
            var k = 0;
            string line;
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "docs", "Generico.csv");

            using (var fs = File.OpenRead(filePath))
            using (var reader = new StreamReader(fs))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(';');
                    var codigo = parts[0];
                    var generico = parts[1];
                    if (k > 0)
                    {
                        builder.Entity<Generico>().HasData(
                            new Generico
                            {
                                Codigo = Convert.ToInt32(codigo),
                                Nome = generico
                            });
                    }
                    k++;
                }
            }

            return builder;
        }
    }
}
