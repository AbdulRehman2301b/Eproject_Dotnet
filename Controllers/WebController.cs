using Microsoft.AspNetCore.Mvc;

namespace SymphonyLtd.Controllers
{
    public class WebController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult about()
        {
            return View();
        }
        public IActionResult courses()
        {
            return View();
        }
        public IActionResult exam()
        {
            return View();
        }
        public IActionResult faqs()
        {
            return View();
        }
        public IActionResult contact()
        {
            return View();
        }
    }
}
