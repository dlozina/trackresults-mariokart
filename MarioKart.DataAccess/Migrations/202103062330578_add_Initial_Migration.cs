namespace MarioKart.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_Initial_Migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Announcements",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DateEntered = c.DateTime(),
                        Title = c.String(maxLength: 140),
                        TournamentName = c.String(maxLength: 140),
                        TournamentDate = c.DateTime(),
                        TournamentTime = c.DateTime(),
                        TournamentCallTime = c.DateTime(),
                        Story = c.String(maxLength: 280),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        FavoriteTrack = c.String(),
                        FavoriteCar = c.String(),
                        EntryYear = c.String(),
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
                "dbo.News",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DateEntered = c.DateTime(),
                        NewsTitle = c.String(maxLength: 140),
                        NewsStory = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Races",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RaceDate = c.DateTime(),
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
                        RaceDate = c.DateTime(),
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
            DropTable("dbo.News");
            DropTable("dbo.GrandPrixes");
            DropTable("dbo.Drivers");
            DropTable("dbo.Announcements");
        }
    }
}
