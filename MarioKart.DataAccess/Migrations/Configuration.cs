namespace MarioKart.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MarioKart.DataAccess.Data.MarioKartContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MarioKart.DataAccess.Data.MarioKartContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            DatabaseSeedConfiguration databaseSeedConfiguration = new DatabaseSeedConfiguration();
            databaseSeedConfiguration.Seed(context);
        }
    }
}
