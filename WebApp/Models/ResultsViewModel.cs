using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class ResultsViewModel
    {
        public int yearOne { get; set; }
        public int yearTwo { get; set; }
        public int Result => yearOne;
    }
}
