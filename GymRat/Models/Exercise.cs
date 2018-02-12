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
        //LabelID tells which muscle group
        public int LabelID { get; set; }
        //Type options: weightlifting OR cardio
        public string Type { get; set; }
    }
}
