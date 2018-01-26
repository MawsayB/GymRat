﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymRat.Models;
using System.ComponentModel.DataAnnotations;

namespace GymRat.ViewModels
{
    public class MeasureRecordsViewModel
    {
        public Measure Region { get; set; }
        // put all measurements into a list
        // take the list and sort by Region then date for specific region
        // take the list and show all by Date for ALL

        public List<Measure> Regions { get; set; }

        //public MeasureRecordsViewModel()
        //{
            // populate the list of all the regions
            //Regions = new List<Measure>();

            //foreach (Measure )
        //}

    }
}