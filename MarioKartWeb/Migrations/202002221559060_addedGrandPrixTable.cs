namespace MarioKartWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedGrandPrixTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Races", "DriverID", "dbo.Drivers");
            DropIndex("dbo.Races", new[] { "DriverID" });
            AddColumn("dbo.Races", "TournamentName", c => c.String());
            AddColumn("dbo.Races", "GrandPrixName", c => c.String());
            AddColumn("dbo.Races", "FirstPlaceDriver", c => c.String());
            AddColumn("dbo.Races", "FirstPlaceposition", c => c.Int(nullable: false));
            AddColumn("dbo.Races", "FirstPlacePoints", c => c.Int(nullable: false));
            AddColumn("dbo.Races", "SecondPlaceDriver", c => c.String());
            AddColumn("dbo.Races", "SecondPlacePosition", c => c.Int(nullable: false));
            AddColumn("dbo.Races", "SecondPlacePoints", c => c.Int(nullable: false));
            AddColumn("dbo.Races", "ThirdPlaceDriver", c => c.String());
            AddColumn("dbo.Races", "ThirdPlacePosition", c => c.Int(nullable: false));
            AddColumn("dbo.Races", "ThirdPlacePoints", c => c.Int(nullable: false));
            AddColumn("dbo.Races", "FourthPlaceDriver", c => c.String());
            AddColumn("dbo.Races", "FourthPlacePosition", c => c.Int(nullable: false));
            AddColumn("dbo.Races", "FourthPlacePoints", c => c.Int(nullable: false));
            DropColumn("dbo.Races", "GrandPrix");
            DropColumn("dbo.Races", "Points");
            DropColumn("dbo.Races", "Place");
            DropColumn("dbo.Races", "DriverID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Races", "DriverID", c => c.Int(nullable: false));
            AddColumn("dbo.Races", "Place", c => c.Int(nullable: false));
            AddColumn("dbo.Races", "Points", c => c.Int(nullable: false));
            AddColumn("dbo.Races", "GrandPrix", c => c.String());
            DropColumn("dbo.Races", "FourthPlacePoints");
            DropColumn("dbo.Races", "FourthPlacePosition");
            DropColumn("dbo.Races", "FourthPlaceDriver");
            DropColumn("dbo.Races", "ThirdPlacePoints");
            DropColumn("dbo.Races", "ThirdPlacePosition");
            DropColumn("dbo.Races", "ThirdPlaceDriver");
            DropColumn("dbo.Races", "SecondPlacePoints");
            DropColumn("dbo.Races", "SecondPlacePosition");
            DropColumn("dbo.Races", "SecondPlaceDriver");
            DropColumn("dbo.Races", "FirstPlacePoints");
            DropColumn("dbo.Races", "FirstPlaceposition");
            DropColumn("dbo.Races", "FirstPlaceDriver");
            DropColumn("dbo.Races", "GrandPrixName");
            DropColumn("dbo.Races", "TournamentName");
            CreateIndex("dbo.Races", "DriverID");
            AddForeignKey("dbo.Races", "DriverID", "dbo.Drivers", "ID", cascadeDelete: true);
        }
    }
}
