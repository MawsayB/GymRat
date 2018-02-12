using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GymRat.Models;

namespace GymRat.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        //Measurement table
        public DbSet<Measure> Measurements { get; set; }

        public DbSet<Exercise> Exercises { get; set; }

        public DbSet<ExerciseLabel> ExerciseLabels { get; set; }

        public DbSet<ExerciseType> ExerciseTypes { get; set; }

        public DbSet<Workout> Workouts { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
