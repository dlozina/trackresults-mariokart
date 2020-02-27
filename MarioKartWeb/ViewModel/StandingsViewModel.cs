using MarioKartWeb.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MarioKartWeb.ViewModel
{
    public class StandingsViewModel
    {
        [Display(Name = "Position")]
        public int Position { get; set; }
        [Display(Name = "Driver Name")]
        public string DriverName { get; set; }
        [Display(Name = "Grand Prix Driven")]
        public int GrandPrixDriven { get; set; }
        [Display(Name = "Grand Prix Total")]
        public int GrandPrixTotal { get; set; }
        [Display(Name = "Writer's Corner (Pisarina)")]
        public int WritersCorner { get; set; }
        [Display(Name = "Points")]
        public string Points { get; set; }
       
    }
}