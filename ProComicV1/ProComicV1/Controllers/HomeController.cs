using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProComicV1.Models;

namespace ProComicV1.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "¿Quénes somos?";

            return View();
        }

        public IActionResult Calendar()
        {
            ViewData["Message"] = "Checa el calendario de tus cómics favoritos.";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contáctanos.";

            return View();
        }

        public IActionResult Pais()
        {
            ViewData["Message"] = "Paises";
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
