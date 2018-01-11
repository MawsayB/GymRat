using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymRat.Models;
using Microsoft.EntityFrameworkCore;

namespace GymRat.Data
{
    public class GymRatDbContext
    {
        //Measure table
        public DbSet<Measure> Measurements { get; set; }
    }
}
