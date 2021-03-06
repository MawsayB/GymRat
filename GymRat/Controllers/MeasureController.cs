﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GymRat.Data;
using GymRat.Models;
using GymRat.ViewModels;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace GymRat.Controllers
{
    [Authorize]
    public class MeasureController : Controller
    {
        private readonly ApplicationDbContext context;

        public MeasureController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Confirmation()
        {
            return View();
        }

        public IActionResult Search()
        {
            SearchMeasureViewModel measureViewModel = new SearchMeasureViewModel();
            return View(measureViewModel);
        }

        public IActionResult List()
        {
            MeasureMenuViewModel measureMenuViewModel = new MeasureMenuViewModel();

                // display all the entries to the user
                // entries have a date and size and should be grouped into regions

            //sort by date, then by region
                IList<Measure> Measurements = context
                    .Measurements
                    .OrderByDescending(m=>m.Date).ThenBy(m=>m.Region)
                    .ToList();
                return View("List", Measurements);

        }

        public IActionResult Menu()
        {
            MeasureMenuViewModel measureMenuViewModel = new MeasureMenuViewModel();
            return View(measureMenuViewModel);
        }

        public IActionResult Add()
        {
            //create an instance of the entity model with the new list
            AddMeasureViewModel addMeasureViewModel = new AddMeasureViewModel();
            return View(addMeasureViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddMeasureViewModel addMeasureViewModel)
        {
            if (ModelState.IsValid)
            {
                Measure newMeasure = new Measure
                {
                    Date = addMeasureViewModel.Date,
                    Region = addMeasureViewModel.Region,
                    Size = addMeasureViewModel.Size,
                    UserID = User.Identity.Name
                };
                context.Measurements.Add(newMeasure);
                context.SaveChanges();

                return View("Confirmation");
            }

            return View(addMeasureViewModel);
        }

        public IActionResult Index(MeasureViewModel measureViewModel)
        {
            IList<MeasureViewModel> measurements = new List<MeasureViewModel>();
            //sort the table then pull out the 2 variables

            var regions = context
            .Measurements
            .Select(m => m.Region)
            .Distinct()
            .ToList();

            foreach (var region in regions)
            {

                //most recent record, pull the size
                var lastMeasurement = context
                .Measurements
                // m is the RECORD/ENTRY
                .OrderBy(m => m.Date)
                .Where(m => m.Region == region)
                .LastOrDefault();

                // the first entry
                var firstMeasurement = context
                .Measurements
                .OrderBy(m => m.Date)
                .Where(m => m.Region == region)
                .FirstOrDefault();

                if (lastMeasurement != null && firstMeasurement != null)
                {
                    // (last - first Size)
                    MeasureViewModel newMeasureViewModel = new MeasureViewModel();
                    double difference = lastMeasurement.Size - firstMeasurement.Size;
                    newMeasureViewModel.Size = difference;

                    // also show the region that goes with the size
                    newMeasureViewModel.Region = region;

                    // push variables to the View
                    measurements.Add(newMeasureViewModel);
                }
                else
                {
                    MeasureViewModel newMeasureViewModel = new MeasureViewModel();
                    newMeasureViewModel.Size = 0;
                    measurements.Add(newMeasureViewModel);
                }
            }

            // push these variables to the view
            // show variable in the table in the View
            return View("Index", measurements);

        }
    }
}