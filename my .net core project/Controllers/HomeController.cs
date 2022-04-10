using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using my_.net_core_project.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace my_.net_core_project.Controllers
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
            ViewBag.t5 = "akshay saini";
            ViewBag.t6 = 1234;
            ViewBag.t7 = "A";
            ViewBag.t8 = 12.42354;
            ViewBag.t9 = true;

            ViewData["a1"] = "hiii viewdata";
            ViewData["a2"] = 1233;
            ViewData["a3"] = "A";
            ViewData["a4"] = 131.23;
            ViewData["a5"] = true;

            TempData["s1"] = "hiii Tempdata";
            TempData["s2"] = 52367;
            TempData["s3"] = "S";
            TempData["s4"] = 43.5478983;
            TempData["s5"] = false;
            return View();
        }

     

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
