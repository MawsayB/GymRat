using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymRat.Models;

namespace GymRat.ViewModels
{
    public class MeasureMenuViewModel
    {
        public string Region { get; set; }
        public List<MeasureMenuOptions> Regions { get; set; }

        public MeasureMenuViewModel()
        {
            Regions = new List<MeasureMenuOptions>();

            foreach (MeasureMenuOptions enumVal in Enum.GetValues(typeof(MeasureMenuOptions)))
            {
                Regions.Add(enumVal);
            }

        }
    }
}
