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
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MMMM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Race Date")]
        public DateTime RaceDate { get; set; }
        [Required]
        [Display(Name = "Tournament Name")]
        public string TournamentName { get; set; }
        [Required]
        [Display(Name = "Grand Prix Name")]
        public string GrandPrixName { get; set; }
        [Required]
        [Display(Name = "Driver")]
        public string Driver { get; set; }
        [Required]
        [Display(Name = "Position")]
        [Range(1, 12)]
        public int Position { get; set; }
        [Required]
        [Range(1, 60)]
        [Display(Name = "Points")]
        public int Points { get; set; }
        public List<SelectListItem> Tournaments { get; set; }
        public List<SelectListItem> GrandPrixs { get; set; }
        public List<SelectListItem> Drivers { get; set; }
    }
}