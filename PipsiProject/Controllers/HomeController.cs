using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Web;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PipsiProject.Models;

namespace PipsiProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }












        public IActionResult Samochody()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Kontakt()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Rejestracja()
        {
            return View();
        }

        public IActionResult Logowanie()
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
