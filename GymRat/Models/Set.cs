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

        public string UserID { get; set; }
        public DateTime DateOfUse { get; set; }
        public DateTime ScheduledDate { get; set; }
        public int ExerciseID { get; set; }
        public string ExerciseName { get; set; }
        //this is more like RecordID
        public int SetID { get; set; }

        public float Reps1 { get; set; }
        public float Weight1 { get; set; }

        public float Reps2 { get; set; }
        public float Weight2 { get; set; }

        public float Reps3 { get; set; }
        public float Weight3 { get; set; }

        public float Reps4 { get; set; }
        public float Weight4 { get; set; }

        public float Reps5 { get; set; }
        public float Weight5 { get; set; }

        public float Reps6 { get; set; }
        public float Weight6 { get; set; }

    }
}
