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
        [Display(Name = "Workout Name")]
        public DateTime Name { get; set; }

        //region - optional input field
        [Display(Name = "Muscle Group")]
        public int MuscleGroupID { get; set; }

        //TODO: get the list of MuscleGroups
        //public List<SelectListItem> MucleGroups { get; set; }

        //activity
        [Required]
        [Display(Name = "Activity 1")]
        public int ActivityID { get; set; }

        //[Required]
        //[Display(Name = "Activity 2")]
        //public int ActivityID { get; set; }

        //[Required]
        //[Display(Name = "Activity 3")]
        //public int ActivityID { get; set; }

        //[Required]
        //[Display(Name = "Activity 4")]
        //public int ActivityID { get; set; }

        //[Required]
        //[Display(Name = "Activity 5")]
        //public int ActivityID { get; set; }

        //[Required]
        //[Display(Name = "Activity 6")]
        //public int ActivityID { get; set; }

        //# of sets???
        //TODO: make default 3
        [Required]
        [Display(Name = "Number of Sets")]
        public int Sets { get; set; }

        // # of reps in set
        [Required]
        [Display(Name = "Number of Reps")]
        public int Reps { get; set; }

        public AddWorkoutViewModel()

        {

        }

        //public AddWorkoutViewModel(IEnumerable<MuscleGroup> muscleGroup)
        //{

            //BodyRegions = new List<SelectListItem>();

            //foreach (var bodyregion in bodyRegions)
            //{
                //BodyRegions.Add(new SelectListItem
                //{
                    //Value = bodyregion.ID.ToString(),
                    //Text = bodyregion.Name
                //});

            //}

        //}
    }
}
