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
        public IActionResult Create(AddWorkoutViewModel addWorkoutViewModel, int[] exerciseIds)

        {
            if (ModelState.IsValid)
            {
                //do I need this line of code below?
                IList<AddWorkoutViewModel> exercises = new List<AddWorkoutViewModel>();

                foreach (int Id in exerciseIds)
                {
                    Exercise newExercise = context.Exercises.Single(e => e.ID ==
                    addWorkoutViewModel.ExerciseID);
                    //put the int into a list?
         
                    {
                        Workout newWorkout = new Workout
                        {
                            Name = addWorkoutViewModel.Name,
                            Description = addWorkoutViewModel.Description,
                            Exercises = new List<Exercise>(),
                            UserID = User.Identity.Name
                        };
                        newWorkout.Exercises.Add(Exercise);

                        context.Workouts.Add(newWorkout);
                        context.SaveChanges();

                        return View("Confirmation");
                    }
                }

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