﻿using System;
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
        //private GymRatDbContext context;

        //public MeasureController(GymRatDbContext dbContext)
        //{
            //context = dbContext;
        //}

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

        //add measurement screen
        //[HttpGet]
        //public IActionResult Add()
        //{
            //AddMeasureViewModel addMeasureViewModel = new AddMeasureViewModel();

            //return View();
        //}

        //[HttpPost]
        //public IActionResult Add(AddMeasureViewModel addMeasureViewModel)
        //{
            //if (ModelState.IsValid)
            //{
                //Measure newMeasure = new Measure
                //{
                    //Date = addMeasureViewModel.Date,
                    //Region = addMeasureViewModel.Region,
                    //Size = addMeasureViewModel.Size
                //};
                //context.Measurements.Add(newMeasure);
                //context.SaveChanges();

                //return Redirect("http://localhost:65225/Measuring/Index");
            //}

            //return View(addMeasureViewModel);
        //}
    }
}