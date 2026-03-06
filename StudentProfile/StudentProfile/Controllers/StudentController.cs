using Microsoft.AspNetCore.Mvc;
using StudentProfile.EF;
using StudentProfile.Models;

namespace StudentProfile.Controllers
{
    public class StudentController : Controller
    {
        StudentProfileContext db;
        public StudentController(StudentProfileContext db)
        {
            this.db = db;
        }
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
                Cgpa = 3
            };

            return View(student);
        }
        public IActionResult Details(int id)
        {
            var data = db.Details.Find(id);
            return View();
        }

    }
}
