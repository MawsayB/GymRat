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
        public DateTime DateOfUse { get; set; }
        public DateTime ScheduledDate { get; set; }
        public int ExerciseID { get; set; }
        public string ExerciseName { get; set; }
        //this is more like RecordID
        public int SetID { get; set; }
        public float Reps { get; set; }
        public float Weight { get; set; }

    }
}
