﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymRat.Models
{
    public class BodyRegion
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public List<SelectListItem> BodyRegions { get; set; }
    }
}
