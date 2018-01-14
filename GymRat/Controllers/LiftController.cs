using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GymRat.Models;
using GymRat.Data;

namespace GymRat.Controllers
{
    public class LiftController : Controller
    {
        private readonly GymRatDbContext context;

        public LiftController(GymRatDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult Workout()
        {
            // after Workout is complete
            // show User Today's Workout!
            return View();
        }

        public IActionResult TodaysWorkout()
        {
            return View();
        }

    }
}