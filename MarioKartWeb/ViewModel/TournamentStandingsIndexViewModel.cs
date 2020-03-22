using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MarioKartWeb.ViewModel
{
    public class TournamentStandingsIndexViewModel
    {
        public TournamentStandingsIndexViewModel(IEnumerable<TournamentStandingsViewModel> tournamentStandings)
        {
            this.TournamentStandings = tournamentStandings;
            Tournaments = new List<SelectListItem>();
        }

        public IEnumerable<TournamentStandingsViewModel> TournamentStandings { get; private set; }

        [Display(Name = "Tournament Name")]
        public string TournamentName { get; set; }

        public List<SelectListItem> Tournaments { get; set; }
    }
}