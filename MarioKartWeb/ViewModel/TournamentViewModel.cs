using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MarioKartWeb.ViewModel
{
    public class TournamentViewModel
    {
        public TournamentViewModel()
        {
            Drivers = new List<SelectListItem>();
        }
        public int ID { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Race Date")]
        public DateTime? RaceDate { get; set; }
        [Required]
        [Display(Name = "Tournament Name")]
        public string TournamentName { get; set; }
        [Display(Name = "Winer")]
        public string Winer { get; set; }
        [Display(Name = "Points")]
        public int Points { get; set; }
        public List<SelectListItem> Drivers { get; set; }
    }
}