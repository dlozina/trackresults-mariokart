namespace MarioKart.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newsTable : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.News");
        }
    }
}
