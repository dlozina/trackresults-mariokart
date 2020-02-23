using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarioKartWeb.ViewModel
{
    public class RaceViewModel
    {
        public RaceViewModel()
        {
            Tournaments = new List<SelectListItem>();
            GrandPrixs = new List<SelectListItem>();
            Drivers = new List<SelectListItem>();
        }
        public int ID { get; set; }
        [DataType(DataType.Date)]
        public DateTime RaceDate { get; set; }
        public string TournamentName { get; set; }
        public string GrandPrixName { get; set; }
        public string Driver { get; set; }
        public int Position { get; set; }
        public int Points { get; set; }
        public List<SelectListItem> Tournaments { get; set; }
        public List<SelectListItem> GrandPrixs { get; set; }
        public List<SelectListItem> Drivers { get; set; }
    }
}