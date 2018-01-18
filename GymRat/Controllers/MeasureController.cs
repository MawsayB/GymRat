using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GymRat.Data;
using GymRat.Models;
using GymRat.ViewModels;

namespace GymRat.Controllers
{
    public class MeasureController : Controller
    {
        private readonly GymRatDbContext context;

        public MeasureController(GymRatDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Menu()
        {
            return View();
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
                    BodyRegionID = addMeasureViewModel.BodyRegionID,
                    Size = addMeasureViewModel.Size
                };
                context.Measurements.Add(newMeasure);
                context.SaveChanges();

                return Redirect("http://localhost:65225/Measuring/Index");
            }

            return View(addMeasureViewModel);
        }

        //public IActionResult Index(MeasureViewModel measureViewModel)
        //{
        //IList<MeasureViewModel> measurements = new List<MeasureViewModel>();
        //sort the table then pull out the 2 variables

        //var regions = context
        //.Measurements
        //.Select(m => m.Region)
        //.Distinct()
        //.ToList();

        //foreach (var region in regions)
        //{

        // most recent record, pull the size
        //var lastMeasurement = context
        //.Measurements
        // m is the RECORD/ENTRY
        //.OrderBy(m => m.Date)
        //.Where(m => m.Region == region)
        //.LastOrDefault();

        // the first entry
        //var firstMeasurement = context
        //.Measurements
        //.OrderBy(m => m.Date)
        //.Where(m => m.Region == region)
        //.FirstOrDefault();

        //if (lastMeasurement != null && firstMeasurement != null)
        //{
        // (last - first)
        //MeasureViewModel newMeasureViewModel = new MeasureViewModel();
        //double difference = lastMeasurement.Size - firstMeasurement.Size;
        //newMeasureViewModel.Size = difference;
        //newMeasureViewModel.HasData = true;

        //measurements.Add(newMeasureViewModel);
        //}
        //else
        //{
        //MeasureViewModel newMeasureViewModel = new MeasureViewModel();
        //newMeasureViewModel.HasData = false;
        //measurements.Add(newMeasureViewModel);
        //}
        //}

        // push these variables to the view
        // show variable in the table in the View

        //return View("Index", measurements);
        //}

        //pickmeasure screen
    }
}