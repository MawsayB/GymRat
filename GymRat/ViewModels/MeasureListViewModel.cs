using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymRat.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GymRat.ViewModels
{
    public class MeasureListViewModel : Measure
    {
        public List<SelectListItem> Measurements { get; set; }
    }
}
