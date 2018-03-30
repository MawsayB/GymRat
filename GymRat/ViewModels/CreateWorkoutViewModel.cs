using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using GymRat.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GymRat.ViewModels
{
    public class CreateWorkoutViewModel
    {

        [Required]
        [Display(Name = "Workout Name")]
        public string Name { get; set; }

        [Display(Name = "Scheduled For")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        public int ExerciseID { get; set; }

        public int SelectedExercise { get; set; }

        // add IEnumerable for Exercises
        public List<SelectListItem> Exercises { get; set; }

        // makes a drop-down of exercises
        public CreateWorkoutViewModel(IEnumerable<Exercise> exercises)
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

        public CreateWorkoutViewModel()
        {

        }

    }
}
