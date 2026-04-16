using Microsoft.AspNetCore.Mvc;
using synergymarine_v1.Models;
using System.Diagnostics;

namespace synergymarine_v1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        //public IActionResult CompanyProfile()
        //{
        //    return View();
        //}

        //public IActionResult OurDirectors()
        //{
        //    return View();
        //}

        //public IActionResult VisionMission()
        //{
        //    return View();
        //}

        //public IActionResult CoreValues()
        //{
        //    return View();
        //}

        //public IActionResult HSE()
        //{
        //    return View();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
