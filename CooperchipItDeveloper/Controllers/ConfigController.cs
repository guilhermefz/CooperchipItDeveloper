using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace CooperchipItDeveloper.Mvc.Controllers
{
    public class ConfigController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ImportMedicamentos()
        {
            var k = 0;
            string line;

            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            var csvPath = Path.Combine(outPutDirectory, "Csv\\Medicamento.csv");
            string filePath = new Uri(csvPath).LocalPath;

            using (var fs = System.IO.File.OpenRead(filePath))
            using (var reader = new StreamReader(fs))
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(",");
                    // Pular o cabeçalho
                    if (k > 0)
                    {
                        var codigoMedicamento = parts[0];
                        var descricao = parts[1];
                        var generico = parts[2];
                        var genericoId = parts[3];
                    }
                }

            return View();
        }
    }
}
