using GymRat.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GymRat.ViewModels
{
    public class SelectWorkoutViewModel
    {

        [Required]
        [Display(Name = "Select Workout: ")]
        public int WorkoutID { get; set; }

        // add IEnumerable for Workouts
        public List<SelectListItem> Workouts { get; set; }


        // makes a down-down of Workoutss
        public SelectWorkoutViewModel(IEnumerable<Workout> workouts)
        {

            Workouts = new List<SelectListItem>();

            foreach (var workout in workouts)
            {
                Workouts.Add(new SelectListItem
                {
                    Value = workout.WorkoutID.ToString(),
                    Text = workout.Name
                });

            }

        }

        public SelectWorkoutViewModel()
        {

        }
    }
}
