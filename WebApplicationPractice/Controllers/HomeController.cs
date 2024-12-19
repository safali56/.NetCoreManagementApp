using System.Globalization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationPractice.Controllers
{
    public class HomeController : Controller
    {
        public string  Index()
        {
            return "Hello World from the Action Method";
        }
        public String Error()
        {
            return "I have an error here";
        }
    }
}
