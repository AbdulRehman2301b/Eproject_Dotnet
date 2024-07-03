using Microsoft.AspNetCore.Mvc;

namespace SymphonyLtd.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
