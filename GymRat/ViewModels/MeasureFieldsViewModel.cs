using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymRat.Models;

namespace GymRat.ViewModels
{
    public class MeasureFieldsViewModel
    {

        //the current column
        public MeasureDataOptions Column { get; set; }

        //all columns for display (date, region, size, all)
        public List<MeasureDataOptions> Columns { get; set; }

        // all fields in a given column
        public IEnumerable<MeasureField> Fields { get; set; }

    }
}
