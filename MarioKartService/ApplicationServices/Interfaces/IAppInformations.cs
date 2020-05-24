using MarioKart.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioKartService.ApplicationServices.Interfaces
{
    public interface IAppInformations
    {
        Announcement GetLatestAnnouncement();
        DbSet<Announcement> GetAnnouncements();
        void SaveNewAnnouncement(Announcement announcement);
        void EditAnnouncement(Announcement announcement);
        void DeleteAnnouncement(Announcement announcement);
    }
}
