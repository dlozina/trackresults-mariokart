namespace MarioKartWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Races",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RaceDate = c.DateTime(nullable: false),
                        Driver = c.String(),
                        GrandPrix = c.String(),
                        Points = c.Int(nullable: false),
                        Place = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Races");
        }
    }
}
