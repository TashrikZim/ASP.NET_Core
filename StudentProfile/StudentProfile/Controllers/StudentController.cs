using Microsoft.AspNetCore.Mvc;
using StudentProfile.Models;

namespace StudentProfile.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    public IActionResult Profile(int id)
        {
            Student student = new Student()
            {
                Id = id,
                Name = "Tanjil Tashrik ",
                Age = 24,
                Department = "CS",
                Cgpa = "3"
            };

            return View();
        }

    }
}
