﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MarioKartWeb.Models
{
    public class Tournament
    {
        public int ID { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? RaceDate { get; set; }
        public string TournamentName { get; set; }
        public string Winer { get; set; }
        public int Points { get; set; }
    }
}