using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MarioKartWeb.Models
{
    public class Race
    {
        public int ID { get; set; }
        [DataType(DataType.Date)]
        public DateTime RaceDate { get; set; }
        public string Driver { get; set; }
        public string GrandPrix { get; set; }
        public int Points { get; set; }
        public int Place { get; set; }
    }
}