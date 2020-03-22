using MarioKart.Model;
using MarioKartWeb.DataTransferObjects.Standings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioKartService.ApplicationServices.Interfaces
{
    public interface ITournaments
    {
        DbSet<Tournament> GetTournaments();
        void SaveNewTournament(Tournament tournament);
        void EditTournament(Tournament tournament);
        void DeleteTournament(Tournament tournament);
        TournamentStandings CalculateTournamentStandings(string driver, string tournamentName);
        List<TournamentStandings> SortStandingsList(List<TournamentStandings> standingsList);
    }
}
