using Microsoft.AspNetCore.Mvc;

namespace TSE.Controllers
{
    public class OverviewController : Controller
    {
        public IActionResult Farm_Overview()
        {
            return View();
        }
    }
}
