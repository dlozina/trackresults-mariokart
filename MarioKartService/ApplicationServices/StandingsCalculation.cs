using MarioKartService.ApplicationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MarioKart.DataAccess.Data;
using MarioKart.Model;
using MarioKartWeb.DataTransferObjects.Standings;

namespace MarioKartService.ApplicationServices
{
    public class StandingsCalculation : IStandingsCalculation
    {
        MarioKartContext db;
        public StandingsCalculation()
        {
            db = new MarioKartContext();
        }

        public List<Standings> CalculateStandingsForAllDrivers(DbSet<Driver> drivers, int totalNumberOfRaces)
        {
            List<Standings> standingsList = new List<Standings>();

            foreach (var driver in drivers)
            {
                Standings standings = new Standings();
                var driverRaces = db.Races.Where(x => x.Driver.Equals(driver.Name));
                standings.DriverName = driver.Name;
                standings.Points = DriverPointsCalculation(driverRaces);
                standings.GrandPrixDriven = driverRaces.Count();
                standings.GrandPrixTotal = totalNumberOfRaces;
                standings.WritersCorner = standings.GrandPrixTotal - driverRaces.Count();
                standingsList.Add(standings);
            }

            var sortedStandingsList = StandingsList(standingsList);

            return sortedStandingsList;
        }
        private List<Standings> StandingsList(List<Standings> standingsList)
        {
            var sortedStandingsList = standingsList.OrderByDescending(x => x.Points).ToList();
            for (int i = 0; i < sortedStandingsList.Count(); i++)
            {
                sortedStandingsList[i].Position = i + 1;
            }
            standingsList.OrderByDescending(x => x.Points);

            return standingsList;
        }

        public int CalculateTotalNumberOfRaces()
        {
            int totalNumberOfRaces = 0;
            // TO DO don't calculate just entered tournament LINQ
            foreach (var tournament in db.Tournaments.Where(x => x.Points != 0))
            {
                totalNumberOfRaces += 5;
            }
            return totalNumberOfRaces;
        }

        private int DriverPointsCalculation(IQueryable<MarioKart.Model.Race> driverRaces)
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
