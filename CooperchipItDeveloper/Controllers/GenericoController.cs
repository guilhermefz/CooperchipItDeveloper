using Cooperchip.ItDeveloper.Data.Data.ORM;
using CooperchipItDeveloper.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CooperchipItDeveloper.Mvc.Controllers
{
    public class GenericoController : Controller
    {

        private readonly ITDeveloperDbContext _context;

        public GenericoController(ITDeveloperDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var listGenerico = await _context.Genericos.AsNoTracking()
                .OrderBy(o => o.Codigo)
                .ToListAsync();
            return View(listGenerico);
        }

        [HttpGet]
        public async Task<IActionResult> Details(Guid? id)
        {
            if(id.Value == null)
            {
                return NotFound();
            }

            var generico = await _context.Genericos.FirstOrDefaultAsync(m => m.Id == id);
            if (generico == null)
            {
                return NotFound();
            }

            return View(generico);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Generico generico)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(generico);
                    await _context.SaveChangesAsync();
                }
                catch(Exception e)
                {
                    throw new Exception(e.Message);
                }
                return RedirectToAction(nameof(Index));
            }
            return View(generico);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var generico = await _context.Genericos.FindAsync(id);
            if(generico == null)
            {
                return NotFound();
            }
            return View(generico);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, Generico generico)
        {
            if(id != generico.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(generico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if(!GenericoExists(generico.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(generico);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid? id)
        {
            if  (id == null)
            {
                return NotFound(); 
            }

            var generico = await _context.Genericos.FirstOrDefaultAsync(m => m.Id == id);
            if (generico == null)
            {
                return NotFound();
            }

            return View(generico);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var generico = await _context.Genericos.FindAsync(id);
            _context.Genericos.Remove(generico);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool GenericoExists(Guid id)
        {
            return _context.Genericos.Any(m => m.Id == id);
        }
    }
}
