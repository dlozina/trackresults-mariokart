using MarioKart.Model;
using MarioKart.Model.HelperClass;
using System.Collections.Generic;
using System.Data.Entity;

namespace MarioKartService.ApplicationServices.Interfaces
{
    public interface IDrivers
    {
        DbSet<Driver> GetDrivers();
        int SaveNewDriver(Driver driver);
        int EditDriver(Driver driver);
        int DeleteDriver(Driver driver);
        int NumberOfGrandPrixWon(string driver);
        int NumberOfPoints(string driver);
        int GrandPrixEntered(string driver);
        int TournamentsWon(string driver);
        List<GrandPrixResults> OverallGrandPrixResults(string driver);
    }
}