using System;
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
            return View();
        }

        public IActionResult OnTheFly()
        {
            return View();
        }

        public IActionResult Select(SelectWorkoutViewModel selectWorkoutViewModel)
        {
            // show a list of Workout options

            IList<SelectWorkoutViewModel> workouts = new List<SelectWorkoutViewModel>();

            //pull only entries with a UNIQUE date field
            var uniqueWorkouts = context
                .Workouts
                .GroupBy(w => w.Date)
                .Distinct()
                .ToList();

            // for each unique date
            foreach (var workout in uniqueWorkouts)
            {
                // get the row of data for the unique date
                var entry = context
                    .Measurements
                    // m is the RECORD/ENTRY
                    .ToList();

                SelectWorkoutViewModel newSelectWorkoutViewModel = new SelectWorkoutViewModel();

                workouts.Add(newSelectWorkoutViewModel);
            }

            return View("Select", workouts);

        }

        [HttpPost]
        public IActionResult Select()
        {
            return View("Workout");
        }

        public IActionResult Create()
        {
            // show a list of Exercise options
            CreateWorkoutViewModel addWorkoutViewModel = new CreateWorkoutViewModel(context.
            Exercises.OrderBy(e => e.Name).ToList());

            return View(addWorkoutViewModel);
        }

        [HttpPost]
        // grab the drop down menu selection
        public IActionResult Create(CreateWorkoutViewModel addWorkoutViewModel, int[] SelectedExercise)

        {
            if (ModelState.IsValid)
            {
                {

                    foreach (int userSelection in SelectedExercise)
                    {

                        // for each drop-down menu selection  

                        {
                            //make a Workout 

                            // TODO: add SAME WorkoutID to the GROUP of Exercises

                            Workout newWorkoutEntry = new Workout
                            {
                                Name = addWorkoutViewModel.Name,
                                UserID = User.Identity.Name,
                                Date = addWorkoutViewModel.Date,
                                SelectedExercise = userSelection
                            };

                            //save the Workout to the Db
                            context.Workouts.Add(newWorkoutEntry);
                            context.SaveChanges();
                        }
                    }

                }

                return View("CreateConfirmation");
            }

            return View("Create");
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