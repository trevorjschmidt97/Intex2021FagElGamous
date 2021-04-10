using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Intex2021FagElGamous.Models;

namespace Intex2021FagElGamous.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private FagElGamousBYUDBContext context { get; set; }

        public HomeController(ILogger<HomeController> logger, FagElGamousBYUDBContext ctx)
        {
            context = ctx;
            _logger = logger;
        }

        public IActionResult Index()
        {
            Console.WriteLine("HELLOS");

            Console.WriteLine(context.Burials.Count());
            return View();
        }

        public IActionResult Signin()
        {
            GlobalStatic.userID = "ldkfjj";
            return View("Index" );
        }

        public IActionResult Logout()
        {
            GlobalStatic.userID = null;
            return View("Index");
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
