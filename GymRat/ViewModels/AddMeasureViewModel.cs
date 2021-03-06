﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using GymRat.Models;

namespace GymRat.ViewModels
{
    public class AddMeasureViewModel
    {
        [Required]
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        //region
        [Required]
        [Display(Name = "Region")]
        public string Region { get; set; }
        public List<MeasureRegionOptions> Regions { get; set; }

        //size
        [Required]
        [Display(Name = "Current Size")]
        public double Size { get; set; }

        public AddMeasureViewModel()
        {
            Regions = new List<MeasureRegionOptions>();

            foreach (MeasureRegionOptions enumVal in Enum.GetValues(typeof(MeasureRegionOptions)))
            {
                Regions.Add(enumVal);
            }

        }

    }

}
