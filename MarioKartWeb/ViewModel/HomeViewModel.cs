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
        public HomeViewModel(IEnumerable<NewsViewModel> lastNews)
        {
            this.LastNews = lastNews;
        }

        public int ID { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "First Position")]
        public string FirstPosition { get; set; }

        [Display(Name = "Second Position")]
        public string SecondPosition { get; set; }

        [Display(Name = "Third Position")]
        public string ThirdPosition { get; set; }

        [Display(Name = "Fourth Position")]
        public string FourthPosition { get; set; }

        [Display(Name = "Fifth Position")]
        public string FifthPosition { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Tournament Name")]
        public string TournamentName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MMMM/yyyy}")]
        [Display(Name = "Tournament Date")]
        public DateTime TournamentDate { get; set; }

        [DataType(DataType.Time)]
        [Display(Name = "Tournament Time")]
        public DateTime TournamentTime { get; set; }

        [DataType(DataType.Time)]
        [Display(Name = "Tournament Call Time")]
        public DateTime TournamentCallTime { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MMMM/yyyy}")]
        [Display(Name = "Tournament Date")]
        public DateTime NewsDate { get; set; }

        [Display(Name = "News Title")]
        public string NewsTitle { get; set; }

        [Display(Name = "News Title")]
        public string NewsStory { get; set; }

        public IEnumerable<NewsViewModel> LastNews { get; private set; }
    }
}