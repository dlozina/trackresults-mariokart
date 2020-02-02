namespace MarioKartWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedDriversTable : DbMigration
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Drivers");
        }
    }
}
