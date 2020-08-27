using MarioKart.DataAccess.Data;
using MarioKart.Model;
using MarioKart.Model.HelperClass;
using MarioKartService.ApplicationServices.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MarioKartService.ApplicationServices
{
    public class Drivers : IDrivers
    {
        private MarioKartContext db;

        public Drivers()
        {
            db = new MarioKartContext();
        }

        public DbSet<Driver> GetDrivers()
        {
            var drivers = db.Drivers;
            return drivers;
        }
        public int SaveNewDriver(Driver driver)
        {
            db.Drivers.Add(driver);
            return db.SaveChanges();
        }
        public void EditDriver(Driver driver)
        {
            db.Entry(driver).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void DeleteDriver(Driver driver)
        {
            db.Drivers.Remove(driver);
            db.SaveChanges();
        }

        public int NumberOfGrandPrixWon(string driver)
        {
            var numberOfGrandPrixWon = db.Races.Where(x => x.Driver.Equals(driver) && x.Position == 1).Count();
            db.Races.Where(x => x.Driver.Equals(driver) && x.Position == 1);
            return numberOfGrandPrixWon;
        }
        public int NumberOfPoints(string driver)
        {
            var numberOfPoints = db.Races.Where(x => x.Driver.Equals(driver)).Sum(y => y.Points);
            return numberOfPoints;
        }

        public int GrandPrixEntered(string driver)
        {
            var grandPrixEntered = db.Races.Where(x => x.Driver.Equals(driver)).Count();
            return grandPrixEntered;
        }
        public int TournamentsWon(string driver)
        {
            var tournamentsWon = db.Tournaments.Where(x => x.Winer.Equals(driver)).Count();
            return tournamentsWon;
        }
        public List<GrandPrixResults> OverallGrandPrixResults(string driver)
        {
            var grandPrixes = db.GrandPrixes;
            List<GrandPrixResults> grandPrixResults = new List<GrandPrixResults>();
            foreach (var grandPrix in grandPrixes)
            {
                GrandPrixResults gpResult = new GrandPrixResults();
                var numberOfGrandPrixWon = db.Races.Where(x => x.Driver.Equals(driver) && x.GrandPrixName.Equals(grandPrix.Name) && x.Position == 1).Count();
                var numberOfGrandPrixEntered = db.Races.Where(x => x.Driver.Equals(driver) && x.GrandPrixName.Equals(grandPrix.Name)).Count();
                gpResult.GrandPrixName = grandPrix.Name;
                gpResult.GrandPrixWins = numberOfGrandPrixWon;
                gpResult.GrandPrixEntered = numberOfGrandPrixEntered;
                grandPrixResults.Add(gpResult);
            }
            return grandPrixResults;
        }
    }
}