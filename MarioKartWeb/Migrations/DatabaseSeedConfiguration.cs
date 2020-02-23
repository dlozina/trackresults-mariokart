using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace MarioKartWeb.Migrations
{
    public class DatabaseSeedConfiguration
    {
        public void Seed(MarioKartWeb.Data.MarioKartWebContext context)
        {
            if(!context.GrandPrixes.Any())
            {
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
            }
           
            if(!context.Drivers.Any())
            {
                context.Drivers.AddOrUpdate(
                p => p.ID,
                    new Models.Driver { Name = "Link", Description = "Drift Sensei", FavoriteTrack = "Bone Dry Dunes", FavoriteCar = "W 25 Silver Arrow" },
                    new Models.Driver { Name = "Donkey", Description = "Agressive \"lick the line\" drift", FavoriteTrack = "Moo Moo Meadows", FavoriteCar = "Landship" },
                    new Models.Driver { Name = "Tanooki", Description = "Medium \"no risk\" drift", FavoriteTrack = "Chip Chip Beach", FavoriteCar = "W 25 Silver Arrow" },
                    new Models.Driver { Name = "Roy", Description = "More old school turn than drift", FavoriteTrack = "Moo Moo Meadows", FavoriteCar = "W 25 Silver Arrow" },
                    new Models.Driver { Name = "Toad", Description = "Crazy \"some times you win\" drift", FavoriteTrack = "Cheep Cheep Beach", FavoriteCar = "300 SL Roadster" }
                    );
            }

            if (!context.Tournaments.Any())
            {
                context.Tournaments.AddOrUpdate(
                    p => p.ID,
                    new Models.Tournament { TournamentName = "MK1: The Begining", RaceDate = new DateTime(2020,1,5), Winer = "Donkey", Points = 241},
                    new Models.Tournament { TournamentName = "MK2: King Donkey Returns", RaceDate = new DateTime(2020, 1, 12), Winer = "Donkey", Points = 243 },
                    new Models.Tournament { TournamentName = "MK3: Tricky game's", RaceDate = new DateTime(2020, 1, 19), Winer = "Link", Points = 221 },
                    new Models.Tournament { TournamentName = "MK4: Redemption", RaceDate = new DateTime(2020, 1, 26), Winer = "Link", Points = 213 },
                    new Models.Tournament { TournamentName = "MK5: Clash of the Titans", RaceDate = new DateTime(2020, 2, 2), Winer = "Link", Points = 234 },
                    new Models.Tournament { TournamentName = "MK6: Let the Games Begin Again", RaceDate = new DateTime(2020, 2, 9), Winer = "Link", Points = 219 },
                    new Models.Tournament { TournamentName = "MK7: Winter Games", RaceDate = new DateTime(2020, 1, 16), Winer = "Donkey", Points = 229 },
                    new Models.Tournament { TournamentName = "MK8: Death Race", RaceDate = new DateTime(2020, 1, 26), Winer = "Donkey", Points = 218 }
                    );
            }

            if (!context.Races.Any())
            {
                context.Races.AddOrUpdate(
                    p => p.ID,
                    // Race1
                    new Models.Race { RaceDate = new DateTime(2020, 1, 5), TournamentName = "MK1: The Begining", GrandPrixName = "Mushroom Cup", Driver = "Link", Position =1, Points= 47 },
                    new Models.Race { RaceDate = new DateTime(2020, 1, 5), TournamentName = "MK1: The Begining", GrandPrixName = "Mushroom Cup", Driver = "Donkey", Position = 2, Points = 45 },
                    new Models.Race { RaceDate = new DateTime(2020, 1, 5), TournamentName = "MK1: The Begining", GrandPrixName = "Mushroom Cup", Driver = "Roy", Position = 6, Points = 31 },
                    new Models.Race { RaceDate = new DateTime(2020, 1, 5), TournamentName = "MK1: The Begining", GrandPrixName = "Mushroom Cup", Driver = "Tanooki", Position = 3, Points = 41 },
                    // Race2
                    new Models.Race { RaceDate = new DateTime(2020, 1, 5), TournamentName = "MK1: The Begining", GrandPrixName = "Flower Cup", Driver = "Link", Position = 3, Points = 39 },
                    new Models.Race { RaceDate = new DateTime(2020, 1, 5), TournamentName = "MK1: The Begining", GrandPrixName = "Flower Cup", Driver = "Donkey", Position = 1, Points = 52 },
                    new Models.Race { RaceDate = new DateTime(2020, 1, 5), TournamentName = "MK1: The Begining", GrandPrixName = "Flower Cup", Driver = "Toad", Position = 7, Points = 28 },
                    new Models.Race { RaceDate = new DateTime(2020, 1, 5), TournamentName = "MK1: The Begining", GrandPrixName = "Flower Cup", Driver = "Tanooki", Position = 6, Points = 34 },
                    // Race3
                    new Models.Race { RaceDate = new DateTime(2020, 1, 5), TournamentName = "MK1: The Begining", GrandPrixName = "Star Cup", Driver = "Link", Position = 6, Points = 36 },
                    new Models.Race { RaceDate = new DateTime(2020, 1, 5), TournamentName = "MK1: The Begining", GrandPrixName = "Star Cup", Driver = "Donkey", Position = 1, Points = 45 },
                    new Models.Race { RaceDate = new DateTime(2020, 1, 5), TournamentName = "MK1: The Begining", GrandPrixName = "Star Cup", Driver = "Roy", Position = 3, Points = 40 },
                    new Models.Race { RaceDate = new DateTime(2020, 1, 5), TournamentName = "MK1: The Begining", GrandPrixName = "Star Cup", Driver = "Tanooki", Position = 4, Points = 39 },
                    // Race4
                    new Models.Race { RaceDate = new DateTime(2020, 1, 5), TournamentName = "MK1: The Begining", GrandPrixName = "Special Cup", Driver = "Toad", Position = 4, Points = 33 },
                    new Models.Race { RaceDate = new DateTime(2020, 1, 5), TournamentName = "MK1: The Begining", GrandPrixName = "Special Cup", Driver = "Donkey", Position = 1, Points = 51 },
                    new Models.Race { RaceDate = new DateTime(2020, 1, 5), TournamentName = "MK1: The Begining", GrandPrixName = "Special Cup", Driver = "Roy", Position = 6, Points = 30 },
                    new Models.Race { RaceDate = new DateTime(2020, 1, 5), TournamentName = "MK1: The Begining", GrandPrixName = "Special Cup", Driver = "Tanooki", Position = 2, Points = 42 },
                    // Race5
                    new Models.Race { RaceDate = new DateTime(2020, 1, 5), TournamentName = "MK1: The Begining", GrandPrixName = "Egg Cup", Driver = "Link", Position = 6, Points = 34 },
                    new Models.Race { RaceDate = new DateTime(2020, 1, 5), TournamentName = "MK1: The Begining", GrandPrixName = "Egg Cup", Driver = "Donkey", Position = 1, Points = 48},
                    new Models.Race { RaceDate = new DateTime(2020, 1, 5), TournamentName = "MK1: The Begining", GrandPrixName = "Egg Cup", Driver = "Toad", Position = 7, Points = 25 },
                    new Models.Race { RaceDate = new DateTime(2020, 1, 5), TournamentName = "MK1: The Begining", GrandPrixName = "Egg Cup", Driver = "Tanooki", Position = 3, Points = 37 }
                    );
            }

            context.SaveChanges();
        }

    }
}