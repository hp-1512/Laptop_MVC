using Microsoft.AspNetCore.Mvc;

namespace CI_Platform_web.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Forgot()
        {
            return View();
        }
    }
}
