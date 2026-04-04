using IntroEF.EF;
using IntroEF.EF.Tables;
using Microsoft.AspNetCore.Mvc;

namespace IntroEF.Controllers
{
    public class CourseController : Controller
    {
        TeacherDbContext DbData;

        public CourseController(TeacherDbContext db)
        {
            DbData = db;
        }

        public IActionResult Index()
        {
            var data= DbData.Courses.ToList(); 
            return View(data);
        }

        public IActionResult Details(int id)
        {
            var data = DbData.Courses.Find(id);
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Course c)
        {
            DbData.Courses.Add(c); //saves a insert query
            
            var rs = DbData.SaveChanges(); //commits the query return no of rows affected
            if (rs > 0)
            {
                TempData["Msg"] = c.Name + " Created Successfully";
            }

            return RedirectToAction("Index");

           // return View();

        }



    }
}
