using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymRat.Models;
using Microsoft.EntityFrameworkCore;

namespace GymRat.Data.Migrations
{
    public class DbInitializer
    {
        public static void Initialize(GymRatDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any regions.
            if (context.BodyRegions.Any())
            {
                return;   // DB has been seeded
            }

            var BodyRegion = new BodyRegion[]
            {
            new BodyRegion{ID=1, Name="Butt"},
            new BodyRegion{ID=2, Name="Thigh"},
            new BodyRegion{ID=3, Name="Waist"},
            };
            foreach (BodyRegion b in BodyRegion)
            {
                context.BodyRegions.Add(b);
            }
            context.SaveChanges();

            //var MuscleGroup = new MuscleGroup[]
            //{
            //new MuscleGroup{ID=1, Name="Shoulders"},
            //new MuscleGroup{ID=2, Name="Back"},
            //new MuscleGroup{ID=3, Name="Chest"},
            //new MuscleGroup{ID=4, Name="Bisceps & Triceps"},
            //new MuscleGroup{ID=5, Name="Legs & Butt"},
            //};
            //foreach (MuscleGroup m in MuscleGroup)
            //{
            //context.MuscleGroups.Add(m);
            //}
            context.SaveChanges();
        }
    }
}
