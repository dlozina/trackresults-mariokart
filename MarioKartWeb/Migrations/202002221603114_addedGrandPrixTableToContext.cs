namespace MarioKartWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedGrandPrixTableToContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GrandPrixes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GrandPrixes");
        }
    }
}
