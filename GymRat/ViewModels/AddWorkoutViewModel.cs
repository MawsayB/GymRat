﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using GymRat.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GymRat.ViewModels
{
    public class AddWorkoutViewModel
    {

        [Required]
        [Display(Name = "Workout Name")]
        public string Name { get; set; }

        [Display(Name = "Scheduled Date")]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Select Exercises: ")]
        public int ExerciseID { get; set; }

        // add IEnumerable for Exercises
        public List<SelectListItem> Exercises { get; set; }

        // makes a down-down of exercises
        public AddWorkoutViewModel(IEnumerable<Exercise> exercises)
        {

            Exercises = new List<SelectListItem>();

            foreach (var exercise in exercises)
            {
                Exercises.Add(new SelectListItem
                {
                    Value = exercise.ID.ToString(),
                    Text = exercise.Name
                });

            }

        }

        public AddWorkoutViewModel()
        {

        }

    }
}
