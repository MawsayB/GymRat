using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymRat.Models;

namespace GymRat.Data.Migrations
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
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
            new BodyRegion{ID=4, Name="Weight"},
            };
            foreach (BodyRegion b in BodyRegion)
            {
                context.BodyRegions.Add(b);
            }
            context.SaveChanges();
        }
    }
}
