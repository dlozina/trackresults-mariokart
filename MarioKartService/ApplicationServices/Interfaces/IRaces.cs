using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarioKart.Model;

namespace MarioKartService.ApplicationServices.Interfaces
{
    public interface IRaces
    {
        DbSet<Race> GetRaces();
        DbSet<GrandPrix> GetGrandPrixes();
        int SaveNewRace(Race race);
        int EditRace(Race race);
        int DeleteRace(Race race);
        void SaveNewGrandPrix(GrandPrix grandPrix);
        void EditGrandPrix(GrandPrix grandPrix);
        void DeleteGrandPrix(GrandPrix grandPrix);
    }
}
