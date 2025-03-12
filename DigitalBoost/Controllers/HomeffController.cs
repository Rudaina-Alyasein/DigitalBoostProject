using Microsoft.AspNetCore.Mvc;

namespace DigitalBoost.Controllers
{
    public class HomeffController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
