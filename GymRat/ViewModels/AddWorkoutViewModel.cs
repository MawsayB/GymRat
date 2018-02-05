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
        public List<MeasureRegionOptions> Muscles { get; set; }

        //TODO: get the list of MuscleGroups
        //public List<SelectListItem> MucleGroups { get; set; }

    }
}
