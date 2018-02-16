﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GymRat.Models;
using GymRat.Data;
using GymRat.ViewModels;

namespace GymRat.Controllers
{
    public class LiftController : Controller
    {
        private readonly ApplicationDbContext context;

        public LiftController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult Select()
        {
            return View();
        }

        public IActionResult Create()
        {
            // show a list of Exercise options
            AddWorkoutViewModel addWorkoutViewModel = new AddWorkoutViewModel(context.
            Exercises.OrderBy(e => e.Name).ToList());

            return View(addWorkoutViewModel);
        }

        [HttpPost]
        public IActionResult Create(AddWorkoutViewModel addWorkoutViewModel)
        {
            if (ModelState.IsValid)
            {

            }

            return View(addWorkoutViewModel);
        }

        public IActionResult Workout()
        {
            // after Workout is complete
            // show User Today's Workout!
            return View();
        }

        //summary AFTER workout is complete
        public IActionResult TodaysWorkout()
        {
            return View();
        }

    }
}