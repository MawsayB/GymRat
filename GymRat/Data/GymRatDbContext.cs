using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GymRat.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GymRat.Data
{
    public class GymRatDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<BodyRegion> BodyRegions { get; set; }
        public DbSet<Measure> Measurements { get; set; }

        public DbSet<MuscleGroup> MuscleGroups { get; set; }

        public GymRatDbContext(DbContextOptions<GymRatDbContext> options)

            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Ignore<SelectListItem>();
            modelBuilder.Ignore<SelectListGroup>();
            modelBuilder.Entity<BodyRegion>()
                .HasKey(m => m.ID);
        }
    }
}