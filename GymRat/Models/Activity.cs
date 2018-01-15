using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymRat.Models
{
    public class Activity
    {
        public int ID { get; set; }
        public int WorkoutID { get; set; }
        public string Name { get; set; }
        public string MuscleGroupName { get; set; }

        //TODO: add MuscleGroups list
        //public List<SelectListItem> MuscleGroups { get; set; }
    }
}
