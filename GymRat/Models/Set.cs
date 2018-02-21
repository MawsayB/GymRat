using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymRat.Models
{
    public class Set
    {

        // workouts have X sets
        // each exercise is completed X many sets within a workout

        public int UserID { get; set; }
        public DateTime Date { get; set; }
        public int WorkoutID { get; set; }
        public int ExerciseID { get; set; }
        public int SetID { get; set; }
        public int ActualReps { get; set; }
        public float Weight { get; set; }

    }
}
