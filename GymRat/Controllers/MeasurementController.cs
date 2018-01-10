﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GymRat.Controllers
{
    public class MeasurementController : Controller
    {
        private GymRatDbContext context;

        public MeasureController(GymratDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index(MeasureIndexViewModel measureIndexViewModel)
        {
            IList<MeasureIndexViewModel> measurements = new List<MeasureIndexViewModel>();
            //sort the table then pull out the 2 variables

            var regions = context
                .Measurements
                .Select(m => m.Region)
                .Distinct()
                .ToList();

            foreach (var region in regions)
            {

                // most recent record, pull the size
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
                    // (last - first)
                    MeasureIndexViewModel newMeasureIndexViewModel = new MeasureIndexViewModel();
                    double difference = lastMeasurement.Size - firstMeasurement.Size;
                    newMeasureIndexViewModel.Size = difference;
                    newMeasureIndexViewModel.HasData = true;

                    measurements.Add(newMeasureIndexViewModel);
                }
                else
                {
                    MeasureIndexViewModel newMeasureIndexViewModel = new MeasureIndexViewModel();
                    newMeasureIndexViewModel.HasData = false;
                    measurements.Add(newMeasureIndexViewModel);
                }
            }

            // push these variables to the view
            // show variable in the table in the View

            return View("Index", measurements);
        }

        //pickmeasure screen
        public IActionResult PickMeasure()
        {
            return View();
        }

        //add measurement screen
        [HttpGet]
        public IActionResult Add()
        {
            AddMeasureViewModel addMeasureViewModel = new AddMeasureViewModel();

            return View();
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
                    Size = addMeasureViewModel.Size
                };
                context.Measurements.Add(newMeasure);
                context.SaveChanges();

                return Redirect("http://localhost:65225/Measuring/Index");
            }

            return View(addMeasureViewModel);
        }
    }
}