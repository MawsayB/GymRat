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
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<BodyRegion> BodyRegions { get; set; }
        public DbSet<Measure> Measurements { get; set; }

        public DbSet<MuscleGroup> MuscleGroups { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)

            : base(options)
        {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<BodyRegion>()
            //.HasKey(c => new { b.BodyRegionID, b.ID });
            modelBuilder.Ignore<SelectListItem>();
            modelBuilder.Ignore<SelectListGroup>();
        }
    }
}