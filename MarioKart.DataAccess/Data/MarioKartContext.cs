using MarioKart.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MarioKart.DataAccess.Data
{
    public class MarioKartContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MarioKartContext() : base("name=MarioKartWebContext")
        {
            //Database.SetInitializer(new GrandPrixesDBInitializer());
        }
        public DbSet<MarioKart.Model.Driver> Drivers { get; set; }
        public DbSet<MarioKart.Model.GrandPrix> GrandPrixes { get; set; }
        public DbSet<MarioKart.Model.Race> Races { get; set; }
        public DbSet<MarioKart.Model.Tournament> Tournaments { get; set; }
    }
}
