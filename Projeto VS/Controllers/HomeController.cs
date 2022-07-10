using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projeto_VS.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_VS.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //instanciar
            HomeModel home = new HomeModel();
            //setar valores
            home.Name = "Ana Paula";
            home.Email = "paulabrufato@email.com";

            return View(home);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}