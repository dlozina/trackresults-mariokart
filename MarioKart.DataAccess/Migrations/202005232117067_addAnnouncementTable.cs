namespace MarioKart.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAnnouncementTable : DbMigration
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
        }
        
        public override void Down()
        {
            DropTable("dbo.Announcements");
        }
    }
}
