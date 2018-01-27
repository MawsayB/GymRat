using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymRat.Models;
using System.ComponentModel.DataAnnotations;

namespace GymRat.ViewModels
{
    public class SearchMeasureViewModel
    {
        //the current column
        public MeasureDataOptions Column { get; set; }

        //all columns for display (date, region, size, all)
        public List<MeasureDataOptions> Columns { get; set; }

        //a list of measurements to show the user
        public List<Measure> Measurements { get; set;}

        //the search term/VALUE
        [Display(Name = "Keyword")]
        public string Value { get; set; } = "";

        //makes a list of all the Measure data options
        public SearchMeasureViewModel()
        {
            Columns = new List<MeasureDataOptions>();

            foreach (MeasureDataOptions enumVal in Enum.GetValues(typeof(MeasureDataOptions)))
            {
                Columns.Add(enumVal);
            }

        }

    }
}
