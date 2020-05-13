using MarioKart.Model.HelperClass;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MarioKartWeb.ViewModel
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
            OverallGrandPrixResults = new List<GrandPrixResults>();
        }
        public int ID { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Position")]
        public int Position { get; set; }
        public List<GrandPrixResults> OverallGrandPrixResults;
    }
}