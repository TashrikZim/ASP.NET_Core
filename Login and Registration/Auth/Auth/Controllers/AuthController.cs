using Auth.DTOs;
using Auth.EF;
using Auth.EF.Tables;
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
        [HttpPost]
        public IActionResult Registration(RegisterDTO obj)
        {
            if (ModelState.IsValid)
            {
                var user = new User()
                {
                    Name = obj.Name,
                    Email = obj.Email,
                    Password = obj.Password,
                    Username = obj.Username,
                    Type = 2
                };
                db_data.Users.Add(user);
                db_data.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
            
        }
    }
}
