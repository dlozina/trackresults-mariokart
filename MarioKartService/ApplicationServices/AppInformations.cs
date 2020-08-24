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
        public News GetLatestNews()
        {
            var latestNews = db.News.OrderByDescending(x => x.ID).FirstOrDefault();
            return latestNews;
        }

        public IQueryable<News> GetLastNoOfNews(int numerOfNews)
        {
            var newss = db.News;
            //var test = Newss.OrderBy(x => x.ID).Skip(Math.Max(0, Newss.Count() - numerOfNews));
            //return Newss.Skip(Math.Max(0, Newss.Count() - numerOfNews));
            var selectedNews = newss.OrderByDescending(x => x.ID).Take(numerOfNews);
            return selectedNews;
        }

        public DbSet<News> GetNews()
        {
            var Newss = db.News;
            return Newss;
        }
        public void SaveNewNews(News News)
        {
            db.News.Add(News);
            db.SaveChanges();
        }
        public void EditNews(News News)
        {
            db.Entry(News).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void DeleteNews(News News)
        {
            db.News.Remove(News);
            db.SaveChanges();
        }
    }
}
