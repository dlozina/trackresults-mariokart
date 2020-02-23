namespace MarioKartWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedDateTimeFieldTournament : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tournaments", "RaceDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tournaments", "RaceDate", c => c.DateTime(nullable: false));
        }
    }
}
