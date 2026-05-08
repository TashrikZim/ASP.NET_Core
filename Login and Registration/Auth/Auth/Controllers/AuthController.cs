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
        [HttpGet]
        public IActionResult Login()
        {
            return View(new LoginDTO());
        }


        [HttpPost]
        public IActionResult Login(LoginDTO obj)
        {

            if (ModelState.IsValid)
            {
                var user = (from u in db_data.Users
                            where u.Username.Equals(obj.Username)
                            && u.Password.Equals(obj.Password)
                            select u).FirstOrDefault();

                if (user != null)
                {
                    return RedirectToAction("Dashboard", "Home");
                }
                ModelState.AddModelError("", "Invalud Username or Password");
            }

            return View(obj);
        }
    }
}
