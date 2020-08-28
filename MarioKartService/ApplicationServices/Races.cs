using MarioKart.DataAccess.Data;
using MarioKartService.ApplicationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarioKart.Model;

namespace MarioKartService.ApplicationServices
{
    public class Races : IRaces
    {
        private MarioKartContext db;

        public Races()
        {
            db = new MarioKartContext();
        }

        public DbSet<Race> GetRaces()
        {
            var drivers = db.Races;
            return drivers;
        }
        public DbSet<GrandPrix> GetGrandPrixes()
        {
            var grandPrix = db.GrandPrixes;
            return grandPrix;
        }
        public int SaveNewRace(Race race)
        {
            db.Races.Add(race);
            return db.SaveChanges();
        }
        public int EditRace(Race race)
        {
            db.Entry(race).State = EntityState.Modified;
            return db.SaveChanges();
        }
        public int DeleteRace(Race race)
        {
            db.Races.Remove(race);
            return db.SaveChanges();
        }

        public void SaveNewGrandPrix(GrandPrix grandPrix)
        {
            db.GrandPrixes.Add(grandPrix);
            db.SaveChanges();
        }
        public void EditGrandPrix(GrandPrix grandPrix)
        {
            db.Entry(grandPrix).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void DeleteGrandPrix(GrandPrix grandPrix)
        {
            db.GrandPrixes.Remove(grandPrix);
            db.SaveChanges();
        }
    }
}
