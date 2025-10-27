using Cooperchip.ItDeveloper.Data.Data.ORM;
using Cooperchip.ITDeveloper.Application.Extensions;
using CooperchipItDeveloper.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            var fileName = ImportsUtils.GetFilePath("docs", "Medicamento", ".csv");
            ReadWriteFile rwf = new ReadWriteFile();
            if (!await rwf.ReadAndWriteCsvAsync(fileName, _context))
                return View("JaTemMedicamento", _context.Medicamentos.AsNoTracking().OrderBy(o => o.Codigo));

            return View("ListaMedicamentos", _context.Medicamentos.AsNoTracking().OrderBy(o => o.Codigo));
        }
    }
}
