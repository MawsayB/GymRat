using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymRat.Models
{
    public class MuscleGroup
    {
        //ID for entry
        public int ID { get; set; }
        public string Name { get; set; }
        public List<SelectListItem> MuscleGroups { get; set; }

        //to cross reference Workout table
        public int WorkoutID { get; set; }

        //to cross reference Activity table
        public int ActivityID { get; set; }
    }
}
