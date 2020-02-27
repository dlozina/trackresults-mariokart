using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarioKartWeb.ViewModel
{
    public class StandingsIndexViewModel
    {
        public StandingsIndexViewModel(IEnumerable<StandingsViewModel> standings)
        {
            this.Standings = standings;
        }
        public IEnumerable<StandingsViewModel> Standings { get; private set; }
    }
}