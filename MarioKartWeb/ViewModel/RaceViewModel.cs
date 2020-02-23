using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MarioKartWeb.ViewModel
{
    public class RaceViewModel
    {
        public int ID { get; set; }
        [DataType(DataType.Date)]
        public DateTime RaceDate { get; set; }
        public string TournamentName { get; set; }
        public string GrandPrixName { get; set; }
        public string Driver { get; set; }
        public int Position { get; set; }
        public int Points { get; set; }
    }
}