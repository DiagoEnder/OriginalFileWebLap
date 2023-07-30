using Microsoft.AspNetCore.Mvc;

namespace OriginalFileWebLap.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DataSqlController : Controller
    {
        public IActionResult Update_Delete_Add()
        {
            return View();
        }
    }
}
