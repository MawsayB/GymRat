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
        [Display(Name = "Use On")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Muscle Group(s)")]
        public string Muscle { get; set; }
        public List<MuscleGroups> Muscles { get; set; }

        public AddWorkoutViewModel()
        {
            Muscles = new List<MuscleGroups>();

            foreach (MuscleGroups enumVal in Enum.GetValues(typeof(MuscleGroups)))
            {
                Muscles.Add(enumVal);
            }

        }

    }
}
