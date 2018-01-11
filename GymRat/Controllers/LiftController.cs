using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GymRat.Models;

namespace GymRat.Controllers
{
    public class LiftController : Controller
    {
        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult Workout()
        {
            return View();
        }

    }
}