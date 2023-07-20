using Microsoft.AspNetCore.Mvc;

namespace OriginalFileWebLap.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DataanalysisController : Controller
    {
        public IActionResult Dataanalysis2()
        {
            return View();
        }
    }
}
