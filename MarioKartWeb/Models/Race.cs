using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MarioKartWeb.Models
{
    public class Race
    {
        public int ID { get; set; }
        [DataType(DataType.Date)]
        public DateTime RaceDate { get; set; }
        public string TournamentName { get; set; }
        public string GrandPrixName { get; set; }
        public string FirstPlaceDriver { get; set; }
        public int FirstPlacePosition { get; set; }
        public int FirstPlacePoints { get; set; }
        public string SecondPlaceDriver { get; set; }
        public int SecondPlacePosition { get; set; }
        public int SecondPlacePoints { get; set; }
        public string ThirdPlaceDriver { get; set; }
        public int ThirdPlacePosition { get; set; }
        public int ThirdPlacePoints { get; set; }
        public string FourthPlaceDriver { get; set; }
        public int FourthPlacePosition { get; set; }
        public int FourthPlacePoints { get; set; }
    }
}