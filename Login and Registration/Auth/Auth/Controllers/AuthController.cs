using Auth.DTOs;
using Auth.EF;
using Microsoft.AspNetCore.Mvc;

namespace Auth.Controllers
{
    public class AuthController : Controller
    {

        AuthRegistrationContext db_data;
        public AuthController(AuthRegistrationContext db)
        {
            db_data = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Registration()
        {
            return View(new RegisterDTO() { });
        }
        public IActionResult Registration(RegisterDTO obj)
        {
            return View(obj);
        }
    }
}
