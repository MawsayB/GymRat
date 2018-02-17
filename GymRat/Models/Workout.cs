using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymRat.Models
{
    public class Workout
    {

        // a Workout consists of 9 exercises
        // 6 are weightlifting exercises
        // 3 are cardio exercises
        public string UserID { get; set; }
        public int WorkoutID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<Exercise> Exercises { get; set; }
    }
}
