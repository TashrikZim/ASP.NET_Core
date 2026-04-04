using Microsoft.AspNetCore.Mvc;
using IntroEF.EF;
using IntroEF.EF.Tables;
using Microsoft.CodeAnalysis.Scripting.Hosting;


namespace IntroEF.Controllers
{
    public class StudentController : Controller
    {
        TeacherDbContext DbData;
        
        public StudentController(TeacherDbContext db)
        {
            DbData = db;
        }


        public IActionResult Index()
        {
            var data = DbData.Students.ToList();
            return View(data);
        }

        [HttpGet]
        public IActionResult Create() { 
        
           return View();       
        }

        [HttpPost]
        public IActionResult Create(Student s)
        {
            DbData.Students.Add(s);

            var rs = DbData.SaveChanges();
            if (rs > 0)
            {
                TempData["Msg"] = "created successfully";
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Scholarship()
        {
            var scholarshipStudent = (from s in DbData.Students where s.Cgpa>=3.75m select s).ToList();
            return View(scholarshipStudent);
        }
    }
}
