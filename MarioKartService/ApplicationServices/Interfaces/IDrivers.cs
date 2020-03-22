using MarioKart.Model;
using System.Data.Entity;

namespace MarioKartService.ApplicationServices.Interfaces
{
    public interface IDrivers
    {
        DbSet<Driver> GetDrivers();
        void SaveNewDriver(Driver driver);
        void EditDriver(Driver driver);
        void DeleteDriver(Driver driver);
        int NumberOfGrandPrixWon(string driver);
        int NumberOfPoints(string driver);
        int GrandPrixEntered(string driver);
        int TournamentsWon(string driver);
    }
}