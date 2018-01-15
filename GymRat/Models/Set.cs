using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymRat.Models
{
    public class Set
    {
        public int ID { get; set; }
        public int WorkoutID { get; set; }
        public int UserID { get; set; }

        public int Rep { get; set; }
        public int Weight { get; set; }
    }
}
