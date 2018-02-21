﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GymRat.Models;
using GymRat.Data;
using GymRat.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace GymRat.Controllers
{
    [Authorize]
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

        public IActionResult CreateConfirmation()
        {

            //TODO: push the name of the exercise through to the View

            return View();
        }

        public IActionResult OnTheFly()
        {
            return View();
        }

        public IActionResult Select()
        {
            SelectWorkoutViewModel selectWorkoutViewModel = new SelectWorkoutViewModel();
            return View(selectWorkoutViewModel);
        }

        public IActionResult Create()
        {
            // show a list of Exercise options
            AddWorkoutViewModel addWorkoutViewModel = new AddWorkoutViewModel(context.
            Exercises.OrderBy(e => e.Name).ToList());

            return View(addWorkoutViewModel);
        }

        [HttpPost]
        // add the drop down menu selection here
        public IActionResult Create(AddWorkoutViewModel addWorkoutViewModel, int[] SelectedExercise)

        {
            if (ModelState.IsValid)
            {
                {

                    foreach (int userSelection in SelectedExercise)

                    // for each drop-down menu selection

                    {
                        //make a Workout
                        Workout newWorkoutEntry = new Workout
                        {
                            Name = addWorkoutViewModel.Name,
                            UserID = User.Identity.Name,
                            Date = addWorkoutViewModel.Date,
                            SelectedExercise = addWorkoutViewModel.SelectedExercise,
                        };

                        //save the Workout to the Db
                        context.Workouts.Add(newWorkoutEntry);
                        context.SaveChanges();
                    }

                }
                return View("CreateConfirmation");
            }

            // can this be written as a return View("Create")?
            return View("localhost:44357/Lift/Create");
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