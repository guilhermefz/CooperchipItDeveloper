using Cooperchip.ItDeveloper.Data.Data.ORM;
using Cooperchip.ITDeveloper.Application.Extensions;
using CooperchipItDeveloper.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;
using X.PagedList;

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
        public IActionResult Index(int? pagina, string ordenacao, string stringBusca)
        {
            const int itensPorPagina = 8;
            int numeroPagina = (pagina ?? 1);

            ViewData["ordenacao"] = ordenacao;
            ViewData["filtroAtual"] = stringBusca;

            var cids = from c in _context.Cids select c;

            if (!string.IsNullOrEmpty(stringBusca)) cids = cids.Where(s => s.Codigo.Contains(stringBusca) || s.Diagnostico.Contains(stringBusca));

            ViewData["OrderByInternalId"] = string.IsNullOrEmpty(ordenacao) ? "CidInternalId_desc" : "";
            ViewData["OrderByCodigo"] = ordenacao == "Codigo" ? "Codigo_desc" : "Codigo";
            ViewData["OrderByDiagnostico"] = ordenacao == "Diagnostico" ? "Diagnostico_desc" : "Diagnostico";

            if (string.IsNullOrEmpty(ordenacao)) ordenacao = "CidInternalId";

            if(ordenacao.EndsWith("_desc"))
            {
                ordenacao = ordenacao.Substring(0, ordenacao.Length - 5);
                cids = cids.OrderByDescending(x => EF.Property<object>(x, ordenacao));
            }else
            {
                cids = cids.OrderBy(x => EF.Property<object>(x, ordenacao));
            }

            var cid = cids.AsNoTracking().ToPagedList(numeroPagina, itensPorPagina);
            return View(cid);
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

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Cid cid)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(cid);
                    await _context.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cid);
        }

        [HttpGet]
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id.Value == null)
            {
                return NotFound();
            }

            var cid = await _context.Cids.FirstOrDefaultAsync(m => m.Id == id);
            if (cid == null)
            {
                return NotFound();
            }

            return View(cid);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cid = await _context.Cids.FirstOrDefaultAsync(m => m.Id == id);
            if (cid == null)
            {
                return NotFound();
            }

            return View(cid);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var cid = await _context.Cids.FindAsync(id);
            _context.Cids.Remove(cid);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid? id)
        {
            if(id ==null)
                return NotFound();

            var cid = await _context.Cids.FindAsync(id);
            
            if(cid == null)
                return NotFound();

            return View(cid);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, Cid cid)
        {
            if(id != cid.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cid);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CidExists(cid.Id))
                    {
                        return NotFound();
                    }else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cid);
        }

        private bool CidExists(Guid id)
        {
            return _context.Cids.Any(m => m.Id == id);
        }
    }
}
