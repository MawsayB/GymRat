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

        public float Weight1 { get; set; }
        public float Reps1 { get; set; }

        public float Weight2 { get; set; }
        public float Reps2 { get; set; }

        public float Weight3 { get; set; }
        public float Reps3 { get; set; }

        public float Weight4 { get; set; }
        public float Reps4 { get; set; }

        public float Weight5 { get; set; }
        public float Reps5 { get; set; }

        public float Weight6 { get; set; }
        public float Reps6 { get; set; }

    }
}
