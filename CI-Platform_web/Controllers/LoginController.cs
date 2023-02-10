using Microsoft.AspNetCore.Mvc;

namespace CI_Platform_web.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
