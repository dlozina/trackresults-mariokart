using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MarioKartWeb.ViewModel
{
    public class TournamentStandingsViewModel
    {
        [Display(Name = "Position")]
        public int Position { get; set; }
        [Display(Name = "Driver Name")]
        public string DriverName { get; set; }
        [Display(Name = "Points")]
        public string Points { get; set; }
    }
}