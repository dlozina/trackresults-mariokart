namespace MarioKartWeb.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MarioKartWeb.Data.MarioKartWebContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MarioKartWeb.Data.MarioKartWebContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            DatabaseSeedConfiguration databaseSeedConfiguration = new DatabaseSeedConfiguration();
            databaseSeedConfiguration.Seed(context);
        }
    }
}
