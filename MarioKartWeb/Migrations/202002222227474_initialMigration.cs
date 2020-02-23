namespace MarioKartWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        FavoriteTrack = c.String(),
                        FavoriteCar = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.GrandPrixes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Races",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RaceDate = c.DateTime(nullable: false),
                        TournamentName = c.String(),
                        GrandPrixName = c.String(),
                        Driver = c.String(),
                        Position = c.Int(nullable: false),
                        Points = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Tournaments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RaceDate = c.DateTime(nullable: false),
                        TournamentName = c.String(),
                        Winer = c.String(),
                        Points = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tournaments");
            DropTable("dbo.Races");
            DropTable("dbo.GrandPrixes");
            DropTable("dbo.Drivers");
        }
    }
}
