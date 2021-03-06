﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GymRat.Data;
using Microsoft.AspNetCore.Authorization;

namespace GymRat.Controllers
{
    [Authorize]
    public class AnalyzeController : Controller
    {
        private readonly ApplicationDbContext context;

        public AnalyzeController(ApplicationDbContext dbContext)
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
    }
}