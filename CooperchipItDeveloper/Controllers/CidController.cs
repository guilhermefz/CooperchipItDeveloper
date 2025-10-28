using Microsoft.AspNetCore.Mvc;

namespace CooperchipItDeveloper.Mvc.Controllers
{
    public class CidController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ImportCid(IFormFile file)
        {
            return View();
        }
    }
}
