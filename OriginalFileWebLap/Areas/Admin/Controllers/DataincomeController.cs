using Microsoft.AspNetCore.Mvc;

namespace OriginalFileWebLap.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DataincomeController : Controller
    {
        public IActionResult Income1()
        {
            return View();
        }

        public IActionResult Income2()
        {
            return View();
        }
    }
}
