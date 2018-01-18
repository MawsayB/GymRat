using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymRat.Models;
using Microsoft.EntityFrameworkCore;

namespace GymRat.Models
{
    public class Measure
    {
        //ID for entry
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public double Size { get; set; }
        //easy way to have consistent regions in table
        public string Region { get; set; }
        //to be able to record for individual users
        public int UserID { get; set; }
    }
}
