using Microsoft.AspNetCore.Mvc;
using StudentProfile.Models;

namespace StudentProfile.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Name = "Tanjil", Salary = 60000, Designation = "Manager" },
                new Employee { Name = "Tashrik", Salary = 45000, Designation = "Developer" },
                new Employee { Name = "Zim", Salary = 55000, Designation = "Analyst" },
                new Employee { Name = "Rahim", Salary = 40000, Designation = "Manager" }
            };

            
            return View(employees);
        }
    }
}
