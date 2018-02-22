using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymRat.Models
{
    public class Exercise
    {
        //ExerciseID
        public int ID { get; set; }
        public string Name { get; set; }
        //Type options: cardio OR weight lifting 
        public string Type { get; set; }
        //public int ExpectedSets { get; set; }
        //public int ExpectedReps { get; set; }
        //public int ActualSets { get; set; }
    }
}
