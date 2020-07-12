using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MarioKartWeb.ViewModel
{
    public class NewsViewModel
    {
        public int ID { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MMMM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date Entered")]
        public DateTime DateEntered { get; set; }

        [Required]
        [Display(Name = "News Title")]
        public string NewsTitle { get; set; }

        [Display(Name = "News Story")]
        public string NewsStory { get; set; }
    }
}