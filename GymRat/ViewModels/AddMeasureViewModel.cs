using Microsoft.AspNetCore.Mvc.Rendering;
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
        [Display(Name = "Date: ")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        //region
        [Required]
        [Display(Name = "Region: ")]
        public int BodyRegionID { get; set; }

        public List<SelectListItem> BodyRegions { get; set; }

        //size
        [Required]
        [Display(Name = "Size: ")]
        public double Size { get; set; }

        public AddMeasureViewModel()

        {

        }

        public AddMeasureViewModel(IEnumerable<BodyRegion> bodyRegions)
        {

            BodyRegions = new List<SelectListItem>();

            foreach (var bodyregion in bodyRegions)
            {
                BodyRegions.Add(new SelectListItem
                {
                    Value = bodyregion.ID.ToString(),
                    Text = bodyregion.Name
                });

            }

        }
    }
}
