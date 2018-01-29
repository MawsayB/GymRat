using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymRat.Models
{
    public class MeasureField
    {
        //gives each measure field an ID
        public int ID { get; set; }
        public static int nextId = 1;

        public string Value { get; set; }

        public MeasureField()
        {
            ID = nextId;
            nextId++;
        }

        public MeasureField (string value) : this ()
        {
            Value = value;
        }
    }
}
