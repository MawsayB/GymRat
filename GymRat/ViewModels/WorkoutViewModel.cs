using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using GymRat.Models;
using System.Collections;

namespace GymRat.ViewModels
{
    public class WorkoutViewModel
    {
        public int ExerciseID { get; set; }

        public string ExerciseName { get; set; }

        public int Weight1 { get; set; }
        public int Reps1 { get; set; }

        public int Weight2 { get; set; }
        public int Reps2 { get; set; }

        public int Weight3 { get; set; }
        public int Reps3 { get; set; }

        public int Weight4 { get; set; }
        public int Reps4 { get; set; }

        public int Weight5 { get; set; }
        public int Reps5 { get; set; }

        public int Weight6 { get; set; }
        public int Reps6 { get; set; }

    }
}
