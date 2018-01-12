using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using GymRat.Models;

namespace GymRat.ViewModels
{
    public class WorkoutViewModel
    {
        public int ID { get; set; }

        public List<SelectListItem> MuscleGroups { get; set; }

        public WorkoutViewModel()

        {

        }

        public WorkoutViewModel(IEnumerable<MuscleGroup> muscleGroups)
        {

            MuscleGroups = new List<SelectListItem>();

            foreach (var musclegroup in muscleGroups)
            {
                MuscleGroups.Add(new SelectListItem
                {
                    Value = musclegroup.ID.ToString(),
                    Text = musclegroup.Name
                });

            }

        }
    }
}
