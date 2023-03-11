using AspNetCore;
using Assessment5B.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Assessment5B.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            return View();
        }
        public IActionResult Welcome()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult SubmitAge(int age) {
            if (age > 889 | age < 426)
             return View("Sorry"); 
            else
            return View("SpaceshipSelection");

        }

        public IActionResult Sorry( int age)
        {
            TempData["young"] = "Sorry, you're too young.";
            TempData["old"] = "Sorry, you're too old.";
            
                return View("Sorry");
        }

        public IActionResult ReadAge( int age)
        {
            return View();
        }

        public IActionResult Spaceship()
        {
            TempData["Ship"]=
            
            return View("SpaceshipSelection"); }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}