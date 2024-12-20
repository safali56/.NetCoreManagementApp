using System.Globalization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationPractice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult  Index()
        {
            return View();
        }
        //public String Error()
        //{
        //    return "I have an error here";
        //}

        
    }
}
