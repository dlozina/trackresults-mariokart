using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MarioKartWeb.ViewModel
{
    public class DriverViewModel
    {
        public int ID { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Favorite Track")]
        public string FavoriteTrack { get; set; }
        [Display(Name = "Favorite Car")]
        public string FavoriteCar { get; set; }
    }
}