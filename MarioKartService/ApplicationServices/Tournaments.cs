using MarioKart.DataAccess.Data;
using MarioKart.Model;
using MarioKartService.ApplicationServices.Interfaces;
using MarioKartWeb.DataTransferObjects.Standings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioKartService.ApplicationServices
{
    public class Tournaments : ITournaments
    {
        MarioKartContext db;
        public Tournaments()
        {
            db = new MarioKartContext();
        }
        public DbSet<Tournament> GetTournaments()
        {
            var tournaments = db.Tournaments;
            return tournaments;
        }
        public void SaveNewTournament(Tournament tournament)
        {
            db.Tournaments.Add(tournament);
            db.SaveChanges();
        }
        public void EditTournament(Tournament tournament)
        {
            db.Entry(tournament).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void DeleteTournament(Tournament tournament)
        {
            db.Tournaments.Remove(tournament);
            db.SaveChanges();
        }
        public TournamentStandings CalculateTournamentStandings(string driver, string tournamentName)
        {
            TournamentStandings tournamentStandings = new TournamentStandings();
            var driverRaces = db.Races.Where(x => x.Driver.Equals(driver) && x.TournamentName.Equals(tournamentName));

            tournamentStandings.DriverName = driver;
            tournamentStandings.Points = DriverPointsCalculation(driverRaces);

            return tournamentStandings;

        }
        public List<TournamentStandings> SortStandingsList(List<TournamentStandings> standingsList)
        {
            var sortedStandingsList = standingsList.OrderByDescending(x => x.Points).ToList();
            for (int i = 0; i < sortedStandingsList.Count(); i++)
            {
                sortedStandingsList[i].Position = i + 1;
            }
            standingsList.OrderByDescending(x => x.Points);

            return standingsList;
        }
        private int DriverPointsCalculation(IQueryable<Race> driverRaces)
        {
            int driverPoints = 0;
            foreach (var driverRace in driverRaces)
            {
                driverPoints += driverRace.Points;
            }
            return driverPoints;
        }
    }
}
