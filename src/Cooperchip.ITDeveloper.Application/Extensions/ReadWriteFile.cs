using Cooperchip.ItDeveloper.Data.Data.ORM;
using CooperchipItDeveloper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.Application.Extensions
{
    public class ReadWriteFile
    {       
        public async Task<bool> ReadAndWriteCsvAsync(string filePath, ITDeveloperDbContext ctx)
        {
            var k = 0;
            string line;

            using (var fs = System.IO.File.OpenRead(filePath))
            using (var sr = new StreamReader(fs))
                while ((line = sr.ReadLine()) != null)
                {
                    var parts = line.Split(";");
                    // Pular o cabeçalho
                    if (k > 0)
                    {
                        int.TryParse(parts[0], out int codigoMedicamento);
                        var descricao = parts[1];
                        var generico = parts[2];
                        int.TryParse(parts[3], out int genericoId);

                        if (JaTemMedicamento(codigoMedicamento, ctx)) return false;
                        ctx.Add(new Medicamento
                        {
                            Codigo = codigoMedicamento,
                            Descricao = descricao,
                            Generico = generico,
                            CodigoGenerico = genericoId
                        });
                    }
                    k++;
                }
            await ctx.SaveChangesAsync();

            return true;
        }

        private bool JaTemMedicamento(int codigoMedicamento, ITDeveloperDbContext ctx)
        {
            return ctx.Medicamentos.Any(e => e.Codigo == codigoMedicamento);
        }
    }
}
