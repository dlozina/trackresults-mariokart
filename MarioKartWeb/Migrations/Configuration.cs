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
            //
            context.GrandPrixes.AddOrUpdate(
                p => p.ID,
                new Models.GrandPrix { Name = "Mushroom Cup" },
                new Models.GrandPrix { Name = "Flower Cup" },
                new Models.GrandPrix { Name = "Star Cup" },
                new Models.GrandPrix { Name = "Special Cup" },
                new Models.GrandPrix { Name = "Egg Cup" },
                new Models.GrandPrix { Name = "Crossing Cup" },
                new Models.GrandPrix { Name = "Shell Cup" },
                new Models.GrandPrix { Name = "Banana Cup" },
                new Models.GrandPrix { Name = "Leaf Cup" },
                new Models.GrandPrix { Name = "Lightning Cup" },
                new Models.GrandPrix { Name = "Triforce Cup" },
                new Models.GrandPrix { Name = "Bell Cup" }
            );

            context.Drivers.AddOrUpdate(
                p => p.ID,
                new Models.Driver { Name = "Link", Description = "Drift Sensei", FavoriteTrack = "Bone Dry Dunes", FavoriteCar = "W 25 Silver Arrow" },
                new Models.Driver { Name = "Donkey", Description = "Agressive \"lick the line\" drift", FavoriteTrack = "Moo Moo Meadows", FavoriteCar = "Landship" },
                new Models.Driver { Name = "Tanooki", Description = "Medium \"no risk\" drift", FavoriteTrack = "Chip Chip Beach", FavoriteCar = "W 25 Silver Arrow" },
                new Models.Driver { Name = "Roy", Description = "More old school turn than drift", FavoriteTrack = "Moo Moo Meadows", FavoriteCar = "W 25 Silver Arrow" },
                new Models.Driver { Name = "Toad", Description = "Crazy \"some times you win\" drift", FavoriteTrack = "Cheep Cheep Beach", FavoriteCar = "300 SL Roadster" }
            );

        }
    }
}
