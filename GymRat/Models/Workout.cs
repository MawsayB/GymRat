using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymRat.Models
{
    public class Workout
    {
        public int ID { get; set; }
        public int UserID { get; set; }

        public DateTime Date { get; set; }
        public string Name { get; set; }
        public int ActivityID { get; set; }
    }
}
