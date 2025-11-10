using Cooperchip.ItDeveloper.Data.Data.ORM;
using Cooperchip.ITDeveloper.Application.Extensions;
using CooperchipItDeveloper.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace CooperchipItDeveloper.Mvc.Controllers
{
    public class CidController : Controller
    {
        private readonly ITDeveloperDbContext _context;

        public CidController(ITDeveloperDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var cids = await _context.Cids.AsNoTracking().OrderBy(o => o.CidInternalId).Where( c => c.CidInternalId < 1000).ToListAsync();

            return View(cids);
        }

        public IActionResult ArquivoInvalido()
        {
            TempData["arquivoInvalido"] = "O arquivo não é válido!";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ImportCid(IFormFile file, [FromServices] IWebHostEnvironment webHostEnvironment)
        {
            if (!ArquivoValido.EhValido(file, "Cid.Csv")) return RedirectToAction("ArquivoInvalido");

            var filePath = $"{webHostEnvironment.WebRootPath}\\importFile\\{file.FileName}";

            CopiarArquivo.Copiar(file, filePath);

            int k = 0;
            string line;

            List<Cid> cids = new List<Cid>();
            Encoding encodingPage = Encoding.GetEncoding(1252);
            bool detectEncoding = false;

            using (var fs = System.IO.File.OpenRead(filePath))
            using (var stream = new StreamReader(fs, encoding: encodingPage, detectEncoding))
                while ((line = stream.ReadLine()) != null)
                {
                    string[] parts = line.Split(";");
                    if (k > 0)
                    {
                        if(!_context.Cids.Any(e => e.CidInternalId == int.Parse(parts[0])))
                        {
                            cids.Add(new Cid
                            {
                                CidInternalId = int.Parse(parts[0]),
                                Codigo = parts[1],
                                Diagnostico = parts[2]
                            });
                        }
                    }
                    k++;
                }

            if(cids.Any())
            {
                await _context.AddRangeAsync(cids);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
