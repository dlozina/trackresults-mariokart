using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarioKart.DataAccess.Data;
using MarioKart.Model;
using MarioKartService.ApplicationServices.Interfaces;

namespace MarioKartService.ApplicationServices
{
    public class AppInformations : IAppInformations
    {
        private MarioKartContext db;

        public AppInformations()
        {
            db = new MarioKartContext();
        }

        public Announcement GetLatestAnnouncement()
        {
            var latestAnnouncement = db.Announcements.OrderByDescending(x => x.ID).FirstOrDefault();
            return latestAnnouncement;
        }
        public DbSet<Announcement> GetAnnouncements()
        {
            var Announcements = db.Announcements;
            return Announcements;
        }
        public void SaveNewAnnouncement(Announcement announcement)
        {
            db.Announcements.Add(announcement);
            db.SaveChanges();
        }
        public void EditAnnouncement(Announcement announcement)
        {
            db.Entry(announcement).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void DeleteAnnouncement(Announcement announcement)
        {
            db.Announcements.Remove(announcement);
            db.SaveChanges();
        }

    }
}
