using Cooperchip.ItDeveloper.Data.Data.ORM;
using CooperchipItDeveloper.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace CooperchipItDeveloper.Mvc.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ConfigController : Controller
    {
        private readonly ITDeveloperDbContext _context;

        public ConfigController(ITDeveloperDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ImportMedicamentos()
        {
            var k = 0;
            string line;

            var baseDirectory = Directory.GetCurrentDirectory();
  
            string filePath = Path.Combine(baseDirectory, "docs", "Medicamento.csv");

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

                        _context.Add(new Medicamento
                        {
                            Codigo = codigoMedicamento,
                            Descricao = descricao,
                            Generico = generico,
                            CodigoGenerico = genericoId
                        });
                    }
                    k++;
                }
            await _context.SaveChangesAsync();

            return RedirectToAction("CsvImportado");
        }

        public IActionResult CsvImportado()
        {
            return View();
        }
    }
}
