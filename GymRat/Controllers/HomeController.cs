using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GymRat.Models;

namespace GymRat.Controllers
{
    public class HomeController : Controller
    {
        //home screen
        public IActionResult Index()
        {
            return View();
        }

        //about page
        public IActionResult About()
        {
            return View();
        }
    }
}