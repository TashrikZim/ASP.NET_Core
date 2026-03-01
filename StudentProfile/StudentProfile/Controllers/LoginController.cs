using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using StudentProfile.Models;

namespace StudentProfile.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View(new LoginModel());
        }
        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
           
            if (ModelState.IsValid)
            {
                
                if (model.UName == "admin" && model.Password == "1234")
                {
                   
                    return RedirectToAction("Profile", "Student");
                }

                
                ModelState.AddModelError(string.Empty, "Invalid Username or Password");
            }

           
            return View(model);
        }
    }
}
