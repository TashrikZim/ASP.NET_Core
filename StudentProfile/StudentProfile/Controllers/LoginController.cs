using Microsoft.AspNetCore.Mvc;

namespace StudentProfile.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
