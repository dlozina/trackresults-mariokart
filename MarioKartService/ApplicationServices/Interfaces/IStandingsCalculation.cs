
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
    public interface IStandingsCalculation
    {
        List<Standings> CalculateStandingsForAllDrivers(DbSet<Driver> drivers, int totalNumberOfRaces);
        int CalculateTotalNumberOfRaces();
    }
}
