using MarioKart.Model.HelperClass;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MarioKartWeb.ViewModel
{
    public class DriverInfoViewModel
    {
        public DriverInfoViewModel()
        {
            OverallGrandPrixResults = new List<GrandPrixResults>();
        }
        public int ID { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Grand Prix Won")]
        public int NumberOfGrandPrixWon { get; set; }
        [Display(Name = "Number of Points")]
        public int NumberOfPoints { get; set; }
        [Display(Name = "Grand Prix Entered")]
        public int GrandPrixEntered { get; set; }
        [Display(Name = "Tournaments Won")]
        public int TournamentsWon { get; set; }
        [Display(Name = "Favorite track")]
        public string FavoriteTrack { get; set; }
        [Display(Name = "Favorite Car")]
        public string FavoriteCar { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        public List<GrandPrixResults> OverallGrandPrixResults;
    }
}