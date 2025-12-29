using CooperchipItDeveloper.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CooperchipItDeveloper.Data.Seeds
{
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


        public static ModelBuilder AddCids(this ModelBuilder builder)
        {
            var k = 0;
            string line;
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "docs", "Cid.csv");

            using (var fs = File.OpenRead(filePath))
            using (var reader = new StreamReader(fs))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(';');
                    var cidinternalid = parts[0];
                    var codigo = parts[1];
                    var diagnostico = parts[2];

                    if (k > 0)
                    {
                        builder.Entity<Cid>().HasData(
                            new Cid
                            {
                                CidInternalId = Convert.ToInt32(cidinternalid),
                                Codigo = codigo,
                                Diagnostico = diagnostico
                            });
                    }
                    k++;
                }
            }

            return builder;
        }
    }
}
