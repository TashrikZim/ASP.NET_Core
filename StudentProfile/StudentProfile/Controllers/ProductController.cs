using Microsoft.AspNetCore.Mvc;
using StudentProfile.Models;

namespace StudentProfile.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {

            List<Product> products = new List<Product>
            {
                new Product {Id=1, Name= "Laptop",Price=1200,Category="Tech"},
                new Product {Id=2, Name="CPU",Price=500,Category="Hardware"}
            };

            return View();
        }
         public IActionResult Details()
        {  
        
         
            
            return View(); 
        
        
        }

    }
}
