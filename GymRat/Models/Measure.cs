using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymRat.Models
{
    public class Measure
    {
        //numbering entries
        public int MeasureID { get; set; }
        public DateTime Date { get; set; }
        //this is where on the body
        public string Region { get; set; }
        public double Size { get; set; }
    }
}
