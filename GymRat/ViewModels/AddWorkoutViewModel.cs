using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using GymRat.Models;

namespace GymRat.ViewModels
{
    public class AddWorkoutViewModel
    {

        [Required]
        [Display(Name = "Workout Name: ")]
        public string Name { get; set; }

        [Display(Name = "Short Description: ")]
        public string Description { get; set; }

        // add IEnumerable for Exercises

        

        public AddWorkoutViewModel()
        {

        }

    }
}
