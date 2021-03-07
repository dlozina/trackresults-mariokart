using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace MarioKart.DataAccess.Migrations
{
    public class DatabaseSeedConfiguration
    {
        public void Seed(MarioKart.DataAccess.Data.MarioKartContext context)
        {
            if(!context.GrandPrixes.Any())
            {
                context.GrandPrixes.AddOrUpdate(
                p => p.ID,
                    new Model.GrandPrix { Name = "Mushroom Cup" },
                    new Model.GrandPrix { Name = "Flower Cup" },
                    new Model.GrandPrix { Name = "Star Cup" },
                    new Model.GrandPrix { Name = "Special Cup" },
                    new Model.GrandPrix { Name = "Egg Cup" },
                    new Model.GrandPrix { Name = "Crossing Cup" },
                    new Model.GrandPrix { Name = "Shell Cup" },
                    new Model.GrandPrix { Name = "Banana Cup" },
                    new Model.GrandPrix { Name = "Leaf Cup" },
                    new Model.GrandPrix { Name = "Lightning Cup" },
                    new Model.GrandPrix { Name = "Triforce Cup" },
                    new Model.GrandPrix { Name = "Bell Cup" }
                    );
            }
           
            if(!context.Drivers.Any())
            {
                context.Drivers.AddOrUpdate(
                p => p.ID,
                    new Model.Driver { Name = "Link", Description = "Drift Sensei", FavoriteTrack = "Bone Dry Dunes", FavoriteCar = "W 25 Silver Arrow", EntryYear = "2020" },
                    new Model.Driver { Name = "Donkey", Description = "Agressive \"lick the line\" drift", FavoriteTrack = "Moo Moo Meadows", FavoriteCar = "Landship", EntryYear = "2020" },
                    new Model.Driver { Name = "Tanooki", Description = "Medium \"no risk\" drift", FavoriteTrack = "Chip Chip Beach", FavoriteCar = "W 25 Silver Arrow", EntryYear = "2020" },
                    new Model.Driver { Name = "Roy", Description = "More old school turn than drift", FavoriteTrack = "Moo Moo Meadows", FavoriteCar = "W 25 Silver Arrow", EntryYear = "2020" },
                    new Model.Driver { Name = "Toad", Description = "Crazy \"some times you win\" drift", FavoriteTrack = "Cheep Cheep Beach", FavoriteCar = "300 SL Roadster", EntryYear = "2020" }
                    );
            }

            if (!context.Tournaments.Any())
            {
                context.Tournaments.AddOrUpdate(
                    p => p.ID,
                    new Model.Tournament { TournamentName = "MK1:The Begining", RaceDate = new DateTime(2020,1,5), Winer = "Donkey", Points = 241},
                    new Model.Tournament { TournamentName = "MK2:King Donkey Returns", RaceDate = new DateTime(2020, 1, 12), Winer = "Donkey", Points = 243 },
                    new Model.Tournament { TournamentName = "MK3:Tricky game's", RaceDate = new DateTime(2020, 1, 19), Winer = "Link", Points = 221 },
                    new Model.Tournament { TournamentName = "MK4:Redemption", RaceDate = new DateTime(2020, 1, 26), Winer = "Link", Points = 213 },
                    new Model.Tournament { TournamentName = "MK5:Clash of the Titans", RaceDate = new DateTime(2020, 2, 2), Winer = "Link", Points = 234 },
                    new Model.Tournament { TournamentName = "MK6:Let the Games Begin Again", RaceDate = new DateTime(2020, 2, 9), Winer = "Link", Points = 219 },
                    new Model.Tournament { TournamentName = "MK7:Winter Games", RaceDate = new DateTime(2020, 2, 16), Winer = "Donkey", Points = 229 },
                    new Model.Tournament { TournamentName = "MK8:Death Race", RaceDate = new DateTime(2020, 2, 23), Winer = "Donkey", Points = 218 },
                    new Model.Tournament { TournamentName = "MK9:Return of the Written-off", RaceDate = new DateTime(2020, 3, 1)}
                    );
            }

            if (!context.Races.Any())
            {
                context.Races.AddOrUpdate(
                    p => p.ID,
                    //////////////////////
                    // Race1
                    new Model.Race { RaceDate = new DateTime(2020, 1, 5), TournamentName = "MK1:The Begining", GrandPrixName = "Mushroom Cup", Driver = "Link", Position =1, Points= 47 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 5), TournamentName = "MK1:The Begining", GrandPrixName = "Mushroom Cup", Driver = "Donkey", Position = 2, Points = 45 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 5), TournamentName = "MK1:The Begining", GrandPrixName = "Mushroom Cup", Driver = "Roy", Position = 6, Points = 31 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 5), TournamentName = "MK1:The Begining", GrandPrixName = "Mushroom Cup", Driver = "Tanooki", Position = 3, Points = 41 },
                    // Race2
                    new Model.Race { RaceDate = new DateTime(2020, 1, 5), TournamentName = "MK1:The Begining", GrandPrixName = "Flower Cup", Driver = "Link", Position = 3, Points = 39 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 5), TournamentName = "MK1:The Begining", GrandPrixName = "Flower Cup", Driver = "Donkey", Position = 1, Points = 52 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 5), TournamentName = "MK1:The Begining", GrandPrixName = "Flower Cup", Driver = "Toad", Position = 7, Points = 28 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 5), TournamentName = "MK1:The Begining", GrandPrixName = "Flower Cup", Driver = "Tanooki", Position = 6, Points = 34 },
                    // Race3
                    new Model.Race { RaceDate = new DateTime(2020, 1, 5), TournamentName = "MK1:The Begining", GrandPrixName = "Star Cup", Driver = "Link", Position = 6, Points = 36 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 5), TournamentName = "MK1:The Begining", GrandPrixName = "Star Cup", Driver = "Donkey", Position = 1, Points = 45 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 5), TournamentName = "MK1:The Begining", GrandPrixName = "Star Cup", Driver = "Roy", Position = 3, Points = 40 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 5), TournamentName = "MK1:The Begining", GrandPrixName = "Star Cup", Driver = "Tanooki", Position = 4, Points = 39 },
                    // Race4
                    new Model.Race { RaceDate = new DateTime(2020, 1, 5), TournamentName = "MK1:The Begining", GrandPrixName = "Special Cup", Driver = "Toad", Position = 4, Points = 33 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 5), TournamentName = "MK1:The Begining", GrandPrixName = "Special Cup", Driver = "Donkey", Position = 1, Points = 51 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 5), TournamentName = "MK1:The Begining", GrandPrixName = "Special Cup", Driver = "Roy", Position = 6, Points = 30 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 5), TournamentName = "MK1:The Begining", GrandPrixName = "Special Cup", Driver = "Tanooki", Position = 2, Points = 42 },
                    // Race5
                    new Model.Race { RaceDate = new DateTime(2020, 1, 5), TournamentName = "MK1:The Begining", GrandPrixName = "Egg Cup", Driver = "Link", Position = 6, Points = 34 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 5), TournamentName = "MK1:The Begining", GrandPrixName = "Egg Cup", Driver = "Donkey", Position = 1, Points = 48},
                    new Model.Race { RaceDate = new DateTime(2020, 1, 5), TournamentName = "MK1:The Begining", GrandPrixName = "Egg Cup", Driver = "Toad", Position = 7, Points = 25 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 5), TournamentName = "MK1:The Begining", GrandPrixName = "Egg Cup", Driver = "Tanooki", Position = 3, Points = 37 },
                    /////////////////////
                    

                    // Race1
                    new Model.Race { RaceDate = new DateTime(2020, 1, 12), TournamentName = "MK2:King Donkey Returns", GrandPrixName = "Crossing Cup", Driver = "Link", Position = 6, Points = 33 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 12), TournamentName = "MK2:King Donkey Returns", GrandPrixName = "Crossing Cup", Driver = "Donkey", Position = 1, Points = 45 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 12), TournamentName = "MK2:King Donkey Returns", GrandPrixName = "Crossing Cup", Driver = "Roy", Position = 7, Points = 27 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 12), TournamentName = "MK2:King Donkey Returns", GrandPrixName = "Crossing Cup", Driver = "Tanooki", Position = 3, Points = 39 },
                    // Race2
                    new Model.Race { RaceDate = new DateTime(2020, 1, 12), TournamentName = "MK2:King Donkey Returns", GrandPrixName = "Shell Cup", Driver = "Link", Position = 1, Points = 49 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 12), TournamentName = "MK2:King Donkey Returns", GrandPrixName = "Shell Cup", Driver = "Donkey", Position = 2, Points = 48 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 12), TournamentName = "MK2:King Donkey Returns", GrandPrixName = "Shell Cup", Driver = "Toad", Position = 7, Points = 29 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 12), TournamentName = "MK2:King Donkey Returns", GrandPrixName = "Shell Cup", Driver = "Tanooki", Position = 3, Points = 38 },
                    // Race3
                    new Model.Race { RaceDate = new DateTime(2020, 1, 12), TournamentName = "MK2:King Donkey Returns", GrandPrixName = "Banana Cup", Driver = "Link", Position = 2, Points = 43 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 12), TournamentName = "MK2:King Donkey Returns", GrandPrixName = "Banana Cup", Driver = "Donkey", Position = 1, Points = 55 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 12), TournamentName = "MK2:King Donkey Returns", GrandPrixName = "Banana Cup", Driver = "Roy", Position = 8, Points = 19 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 12), TournamentName = "MK2:King Donkey Returns", GrandPrixName = "Banana Cup", Driver = "Tanooki", Position = 6, Points = 30 },
                    // Race4
                    new Model.Race { RaceDate = new DateTime(2020, 1, 12), TournamentName = "MK2:King Donkey Returns", GrandPrixName = "Leaf Cup", Driver = "Link", Position = 3, Points = 41 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 12), TournamentName = "MK2:King Donkey Returns", GrandPrixName = "Leaf Cup", Driver = "Donkey", Position = 1, Points = 47 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 12), TournamentName = "MK2:King Donkey Returns", GrandPrixName = "Leaf Cup", Driver = "Toad", Position = 4, Points = 39 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 12), TournamentName = "MK2:King Donkey Returns", GrandPrixName = "Leaf Cup", Driver = "Tanooki", Position = 2, Points = 42 },
                    // Race5
                    new Model.Race { RaceDate = new DateTime(2020, 1, 12), TournamentName = "MK2:King Donkey Returns", GrandPrixName = "Lightning Cup", Driver = "Link", Position = 7, Points = 27 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 12), TournamentName = "MK2:King Donkey Returns", GrandPrixName = "Lightning Cup", Driver = "Donkey", Position = 1, Points = 48 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 12), TournamentName = "MK2:King Donkey Returns", GrandPrixName = "Lightning Cup", Driver = "Roy", Position = 4, Points = 34 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 12), TournamentName = "MK2:King Donkey Returns", GrandPrixName = "Lightning Cup", Driver = "Tanooki", Position = 3, Points = 39 },

                    ////////////////////
                    // Race1
                    new Model.Race { RaceDate = new DateTime(2020, 1, 19), TournamentName = "MK3:Tricky game's", GrandPrixName = "Triforce Cup", Driver = "Link", Position = 1, Points = 48 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 19), TournamentName = "MK3:Tricky game's", GrandPrixName = "Triforce Cup", Driver = "Donkey", Position = 2, Points = 44 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 19), TournamentName = "MK3:Tricky game's", GrandPrixName = "Triforce Cup", Driver = "Toad", Position = 6, Points = 27 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 19), TournamentName = "MK3:Tricky game's", GrandPrixName = "Triforce Cup", Driver = "Tanooki", Position = 4, Points = 38 },
                    // Race2
                    new Model.Race { RaceDate = new DateTime(2020, 1, 19), TournamentName = "MK3:Tricky game's", GrandPrixName = "Bell Cup", Driver = "Link", Position = 2, Points = 44 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 19), TournamentName = "MK3:Tricky game's", GrandPrixName = "Bell Cup", Driver = "Donkey", Position = 5, Points = 35 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 19), TournamentName = "MK3:Tricky game's", GrandPrixName = "Bell Cup", Driver = "Roy", Position = 4, Points = 37 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 19), TournamentName = "MK3:Tricky game's", GrandPrixName = "Bell Cup", Driver = "Tanooki", Position = 3, Points = 43 },
                    // Race3
                    new Model.Race { RaceDate = new DateTime(2020, 1, 19), TournamentName = "MK3:Tricky game's", GrandPrixName = "Mushroom Cup", Driver = "Link", Position = 3, Points = 41 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 19), TournamentName = "MK3:Tricky game's", GrandPrixName = "Mushroom Cup", Driver = "Toad", Position = 5, Points = 34 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 19), TournamentName = "MK3:Tricky game's", GrandPrixName = "Mushroom Cup", Driver = "Roy", Position = 1, Points = 46 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 19), TournamentName = "MK3:Tricky game's", GrandPrixName = "Mushroom Cup", Driver = "Tanooki", Position = 2, Points = 44 },
                    // Race4
                    new Model.Race { RaceDate = new DateTime(2020, 1, 19), TournamentName = "MK3:Tricky game's", GrandPrixName = "Flower Cup", Driver = "Link", Position = 2, Points = 41 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 19), TournamentName = "MK3:Tricky game's", GrandPrixName = "Flower Cup", Driver = "Donkey", Position = 3, Points = 40 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 19), TournamentName = "MK3:Tricky game's", GrandPrixName = "Flower Cup", Driver = "Roy", Position = 5, Points = 34 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 19), TournamentName = "MK3:Tricky game's", GrandPrixName = "Flower Cup", Driver = "Tanooki", Position = 1, Points = 46 },
                    // Race5
                    new Model.Race { RaceDate = new DateTime(2020, 1, 19), TournamentName = "MK3:Tricky game's", GrandPrixName = "Star Cup", Driver = "Link", Position = 1, Points = 47 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 19), TournamentName = "MK3:Tricky game's", GrandPrixName = "Star Cup", Driver = "Donkey", Position = 3, Points = 40 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 19), TournamentName = "MK3:Tricky game's", GrandPrixName = "Star Cup", Driver = "Toad", Position = 6, Points = 30 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 19), TournamentName = "MK3:Tricky game's", GrandPrixName = "Star Cup", Driver = "Tanooki", Position = 4, Points = 38 },

                    ////////////////////
                    // Race1
                    new Model.Race { RaceDate = new DateTime(2020, 1, 26), TournamentName = "MK4:Redemption", GrandPrixName = "Special Cup", Driver = "Link", Position = 1, Points = 52 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 26), TournamentName = "MK4:Redemption", GrandPrixName = "Special Cup", Driver = "Donkey", Position = 3, Points = 39 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 26), TournamentName = "MK4:Redemption", GrandPrixName = "Special Cup", Driver = "Toad", Position = 6, Points = 28 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 26), TournamentName = "MK4:Redemption", GrandPrixName = "Special Cup", Driver = "Tanooki", Position = 8, Points = 23 },
                    // Race2
                    new Model.Race { RaceDate = new DateTime(2020, 1, 26), TournamentName = "MK4:Redemption", GrandPrixName = "Egg Cup", Driver = "Link", Position = 3, Points = 36 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 26), TournamentName = "MK4:Redemption", GrandPrixName = "Egg Cup", Driver = "Donkey", Position = 1, Points = 53  },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 26), TournamentName = "MK4:Redemption", GrandPrixName = "Egg Cup", Driver = "Roy", Position = 7, Points = 28 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 26), TournamentName = "MK4:Redemption", GrandPrixName = "Egg Cup", Driver = "Toad", Position = 4, Points = 34 },
                    // Race3
                    new Model.Race { RaceDate = new DateTime(2020, 1, 26), TournamentName = "MK4:Redemption", GrandPrixName = "Crossing Cup", Driver = "Link", Position = 1, Points = 40 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 26), TournamentName = "MK4:Redemption", GrandPrixName = "Crossing Cup", Driver = "Donkey", Position = 2, Points = 39 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 26), TournamentName = "MK4:Redemption", GrandPrixName = "Crossing Cup", Driver = "Toad", Position = 7, Points = 28 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 26), TournamentName = "MK4:Redemption", GrandPrixName = "Crossing Cup", Driver = "Tanooki", Position = 6, Points = 35 },
                    // Race4
                    new Model.Race { RaceDate = new DateTime(2020, 1, 26), TournamentName = "MK4:Redemption", GrandPrixName = "Shell Cup", Driver = "Link", Position = 3, Points = 41 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 26), TournamentName = "MK4:Redemption", GrandPrixName = "Shell Cup", Driver = "Donkey", Position = 4, Points = 40 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 26), TournamentName = "MK4:Redemption", GrandPrixName = "Shell Cup", Driver = "Roy", Position = 2, Points = 45 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 26), TournamentName = "MK4:Redemption", GrandPrixName = "Shell Cup", Driver = "Tanooki", Position = 1, Points = 47 },
                    // Race5
                    new Model.Race { RaceDate = new DateTime(2020, 1, 26), TournamentName = "MK4:Redemption", GrandPrixName = "Banana Cup", Driver = "Link", Position = 2, Points = 44 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 26), TournamentName = "MK4:Redemption", GrandPrixName = "Banana Cup", Driver = "Roy", Position = 4, Points = 37 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 26), TournamentName = "MK4:Redemption", GrandPrixName = "Banana Cup", Driver = "Toad", Position = 5, Points = 30 },
                    new Model.Race { RaceDate = new DateTime(2020, 1, 26), TournamentName = "MK4:Redemption", GrandPrixName = "Banana Cup", Driver = "Tanooki", Position = 1, Points = 52 },

                    //////////////////
                    // Race1
                    new Model.Race { RaceDate = new DateTime(2020, 2, 2), TournamentName = "MK5:Clash of the Titans", GrandPrixName = "Leaf Cup", Driver = "Link", Position = 3, Points = 42 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 2), TournamentName = "MK5:Clash of the Titans", GrandPrixName = "Leaf Cup", Driver = "Donkey", Position = 1, Points = 45 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 2), TournamentName = "MK5:Clash of the Titans", GrandPrixName = "Leaf Cup", Driver = "Roy", Position = 6, Points = 27 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 2), TournamentName = "MK5:Clash of the Titans", GrandPrixName = "Leaf Cup", Driver = "Tanooki", Position = 4, Points = 36 },
                    // Race2
                    new Model.Race { RaceDate = new DateTime(2020, 2, 2), TournamentName = "MK5:Clash of the Titans", GrandPrixName = "Lightning Cup", Driver = "Link", Position = 1, Points = 50 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 2), TournamentName = "MK5:Clash of the Titans", GrandPrixName = "Lightning Cup", Driver = "Donkey", Position = 2, Points = 45 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 2), TournamentName = "MK5:Clash of the Titans", GrandPrixName = "Lightning Cup", Driver = "Toad", Position = 7, Points = 28 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 2), TournamentName = "MK5:Clash of the Titans", GrandPrixName = "Lightning Cup", Driver = "Tanooki", Position = 4, Points = 40 },
                    // Race3
                    new Model.Race { RaceDate = new DateTime(2020, 2, 2), TournamentName = "MK5:Clash of the Titans", GrandPrixName = "Triforce Cup", Driver = "Link", Position = 2, Points = 50 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 2), TournamentName = "MK5:Clash of the Titans", GrandPrixName = "Triforce Cup", Driver = "Donkey", Position = 1, Points = 51 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 2), TournamentName = "MK5:Clash of the Titans", GrandPrixName = "Triforce Cup", Driver = "Toad", Position = 5, Points = 31 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 2), TournamentName = "MK5:Clash of the Titans", GrandPrixName = "Triforce Cup", Driver = "Tanooki", Position = 3, Points = 38 },
                    // Race4
                    new Model.Race { RaceDate = new DateTime(2020, 2, 2), TournamentName = "MK5:Clash of the Titans", GrandPrixName = "Bell Cup", Driver = "Link", Position = 2, Points = 45 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 2), TournamentName = "MK5:Clash of the Titans", GrandPrixName = "Bell Cup", Driver = "Donkey", Position = 3, Points = 39 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 2), TournamentName = "MK5:Clash of the Titans", GrandPrixName = "Bell Cup", Driver = "Roy", Position = 7, Points = 29 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 2), TournamentName = "MK5:Clash of the Titans", GrandPrixName = "Bell Cup", Driver = "Tanooki", Position = 6, Points = 32 },
                    // Race5
                    new Model.Race { RaceDate = new DateTime(2020, 2, 2), TournamentName = "MK5:Clash of the Titans", GrandPrixName = "Mushroom Cup", Driver = "Link", Position = 1, Points = 47 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 2), TournamentName = "MK5:Clash of the Titans", GrandPrixName = "Mushroom Cup", Driver = "Donkey", Position = 2, Points = 45 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 2), TournamentName = "MK5:Clash of the Titans", GrandPrixName = "Mushroom Cup", Driver = "Roy", Position = 4, Points = 40 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 2), TournamentName = "MK5:Clash of the Titans", GrandPrixName = "Mushroom Cup", Driver = "Tanooki", Position = 3, Points = 44 },


                    //////////////////
                    // Race1
                    new Model.Race { RaceDate = new DateTime(2020, 2, 9), TournamentName = "MK6:Let the Games Begin Again", GrandPrixName = "Flower Cup", Driver = "Link", Position = 2, Points = 45 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 9), TournamentName = "MK6:Let the Games Begin Again", GrandPrixName = "Flower Cup", Driver = "Donkey", Position = 5, Points = 35 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 9), TournamentName = "MK6:Let the Games Begin Again", GrandPrixName = "Flower Cup", Driver = "Toad", Position = 6, Points = 34 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 9), TournamentName = "MK6:Let the Games Begin Again", GrandPrixName = "Flower Cup", Driver = "Tanooki", Position = 1, Points = 51 },
                    // Race2
                    new Model.Race { RaceDate = new DateTime(2020, 2, 9), TournamentName = "MK6:Let the Games Begin Again", GrandPrixName = "Star Cup", Driver = "Link", Position = 4, Points = 36 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 9), TournamentName = "MK6:Let the Games Begin Again", GrandPrixName = "Star Cup", Driver = "Donkey", Position = 7, Points = 26 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 9), TournamentName = "MK6:Let the Games Begin Again", GrandPrixName = "Star Cup", Driver = "Roy", Position = 1, Points = 49 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 9), TournamentName = "MK6:Let the Games Begin Again", GrandPrixName = "Star Cup", Driver = "Tanooki", Position = 2, Points = 41 },
                    // Race3
                    new Model.Race { RaceDate = new DateTime(2020, 2, 9), TournamentName = "MK6:Let the Games Begin Again", GrandPrixName = "Special Cup", Driver = "Link", Position = 1, Points = 54 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 9), TournamentName = "MK6:Let the Games Begin Again", GrandPrixName = "Special Cup", Driver = "Roy", Position = 6, Points = 23 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 9), TournamentName = "MK6:Let the Games Begin Again", GrandPrixName = "Special Cup", Driver = "Toad", Position = 9, Points = 17 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 9), TournamentName = "MK6:Let the Games Begin Again", GrandPrixName = "Special Cup", Driver = "Tanooki", Position = 5, Points = 26 },
                    // Race4
                    new Model.Race { RaceDate = new DateTime(2020, 2, 9), TournamentName = "MK6:Let the Games Begin Again", GrandPrixName = "Egg Cup", Driver = "Link", Position = 1, Points = 49 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 9), TournamentName = "MK6:Let the Games Begin Again", GrandPrixName = "Egg Cup", Driver = "Donkey", Position = 3, Points = 38 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 9), TournamentName = "MK6:Let the Games Begin Again", GrandPrixName = "Egg Cup", Driver = "Roy", Position = 5, Points = 33 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 9), TournamentName = "MK6:Let the Games Begin Again", GrandPrixName = "Egg Cup", Driver = "Tanooki", Position = 4, Points = 36 },
                    // Race5
                    new Model.Race { RaceDate = new DateTime(2020, 2, 9), TournamentName = "MK6:Let the Games Begin Again", GrandPrixName = "Crossing Cup", Driver = "Link", Position = 4, Points = 35 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 9), TournamentName = "MK6:Let the Games Begin Again", GrandPrixName = "Crossing Cup", Driver = "Donkey", Position = 2, Points = 41 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 9), TournamentName = "MK6:Let the Games Begin Again", GrandPrixName = "Crossing Cup", Driver = "Toad", Position = 7, Points = 31 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 9), TournamentName = "MK6:Let the Games Begin Again", GrandPrixName = "Crossing Cup", Driver = "Tanooki", Position = 1, Points = 49 },


                    //////////////////
                    // Race1
                    new Model.Race { RaceDate = new DateTime(2020, 2, 16), TournamentName = "MK7:Winter Games", GrandPrixName = "Shell Cup", Driver = "Link", Position = 2, Points = 38 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 16), TournamentName = "MK7:Winter Games", GrandPrixName = "Shell Cup", Driver = "Donkey", Position = 1, Points = 57 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 16), TournamentName = "MK7:Winter Games", GrandPrixName = "Shell Cup", Driver = "Toad", Position = 6, Points = 31 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 16), TournamentName = "MK7:Winter Games", GrandPrixName = "Shell Cup", Driver = "Tanooki", Position = 3, Points = 37 },
                    // Race2
                    new Model.Race { RaceDate = new DateTime(2020, 2, 16), TournamentName = "MK7:Winter Games", GrandPrixName = "Banana Cup", Driver = "Link", Position = 1, Points = 46 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 16), TournamentName = "MK7:Winter Games", GrandPrixName = "Banana Cup", Driver = "Donkey", Position = 2, Points = 40 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 16), TournamentName = "MK7:Winter Games", GrandPrixName = "Banana Cup", Driver = "Roy", Position = 4, Points = 39 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 16), TournamentName = "MK7:Winter Games", GrandPrixName = "Banana Cup", Driver = "Tanooki", Position = 4, Points = 39 },
                    // Race3
                    new Model.Race { RaceDate = new DateTime(2020, 2, 16), TournamentName = "MK7:Winter Games", GrandPrixName = "Leaf Cup", Driver = "Link", Position = 1, Points = 48 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 16), TournamentName = "MK7:Winter Games", GrandPrixName = "Leaf Cup", Driver = "Donkey", Position = 3, Points = 39 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 16), TournamentName = "MK7:Winter Games", GrandPrixName = "Leaf Cup", Driver = "Toad", Position = 4, Points = 36 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 16), TournamentName = "MK7:Winter Games", GrandPrixName = "Leaf Cup", Driver = "Roy", Position = 2, Points = 44 },
                    // Race4
                    new Model.Race { RaceDate = new DateTime(2020, 2, 16), TournamentName = "MK7:Winter Games", GrandPrixName = "Lightning Cup", Driver = "Link", Position = 7, Points = 24 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 16), TournamentName = "MK7:Winter Games", GrandPrixName = "Lightning Cup", Driver = "Donkey", Position = 1, Points = 47 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 16), TournamentName = "MK7:Winter Games", GrandPrixName = "Lightning Cup", Driver = "Roy", Position = 6, Points = 34 },
                    new Model.Race { RaceDate = new DateTime(2220, 2, 16), TournamentName = "MK7:Winter Games", GrandPrixName = "Lightning Cup", Driver = "Tanooki", Position = 4, Points = 38 },
                    // Race5
                    new Model.Race { RaceDate = new DateTime(2020, 2, 16), TournamentName = "MK7:Winter Games", GrandPrixName = "Triforce Cup", Driver = "Roy", Position = 7, Points = 26 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 16), TournamentName = "MK7:Winter Games", GrandPrixName = "Triforce Cup", Driver = "Donkey", Position = 1, Points = 46 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 16), TournamentName = "MK7:Winter Games", GrandPrixName = "Triforce Cup", Driver = "Toad", Position = 4, Points = 38 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 16), TournamentName = "MK7:Winter Games", GrandPrixName = "Triforce Cup", Driver = "Tanooki", Position = 2, Points = 45 },


                    //////////////////
                    // Race1
                    new Model.Race { RaceDate = new DateTime(2020, 2, 23), TournamentName = "MK8:Death Race", GrandPrixName = "Bell Cup", Driver = "Link", Position = 8, Points = 21 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 23), TournamentName = "MK8:Death Race", GrandPrixName = "Bell Cup", Driver = "Donkey", Position = 1, Points = 45 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 23), TournamentName = "MK8:Death Race", GrandPrixName = "Bell Cup", Driver = "Toad", Position = 6, Points = 27 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 23), TournamentName = "MK8:Death Race", GrandPrixName = "Bell Cup", Driver = "Tanooki", Position = 3, Points = 43 },
                    // Race2
                    new Model.Race { RaceDate = new DateTime(2020, 2, 23), TournamentName = "MK8:Death Race", GrandPrixName = "Mushroom Cup", Driver = "Roy", Position = 4, Points = 38 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 23), TournamentName = "MK8:Death Race", GrandPrixName = "Mushroom Cup", Driver = "Donkey", Position = 1, Points = 47 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 23), TournamentName = "MK8:Death Race", GrandPrixName = "Mushroom Cup", Driver = "Toad", Position = 5, Points = 35 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 23), TournamentName = "MK8:Death Race", GrandPrixName = "Mushroom Cup", Driver = "Tanooki", Position = 2, Points = 43 },
                    // Race3
                    new Model.Race { RaceDate = new DateTime(2020, 2, 23), TournamentName = "MK8:Death Race", GrandPrixName = "Flower Cup", Driver = "Link", Position = 3, Points = 42 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 23), TournamentName = "MK8:Death Race", GrandPrixName = "Flower Cup", Driver = "Donkey", Position = 1, Points = 45 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 23), TournamentName = "MK8:Death Race", GrandPrixName = "Flower Cup", Driver = "Roy", Position = 5, Points = 35 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 23), TournamentName = "MK8:Death Race", GrandPrixName = "Flower Cup", Driver = "Tanooki", Position = 2, Points = 43 },
                    // Race4
                    new Model.Race { RaceDate = new DateTime(2020, 2, 23), TournamentName = "MK8:Death Race", GrandPrixName = "Star Cup", Driver = "Link", Position = 6, Points = 32 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 23), TournamentName = "MK8:Death Race", GrandPrixName = "Star Cup", Driver = "Donkey", Position = 2, Points = 40 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 23), TournamentName = "MK8:Death Race", GrandPrixName = "Star Cup", Driver = "Toad", Position = 5, Points = 35 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 23), TournamentName = "MK8:Death Race", GrandPrixName = "Star Cup", Driver = "Tanooki", Position = 1, Points = 41 },
                    // Race5
                    new Model.Race { RaceDate = new DateTime(2020, 2, 23), TournamentName = "MK8:Death Race", GrandPrixName = "Special Cup", Driver = "Roy", Position = 2, Points = 40 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 23), TournamentName = "MK8:Death Race", GrandPrixName = "Special Cup", Driver = "Donkey", Position = 1, Points = 41 },
                    new Model.Race { RaceDate = new DateTime(2021, 3, 7), TournamentName = "MK8:Death Race", GrandPrixName = "Special Cup", Driver = "Toad", Position = 7, Points = 26 },
                    new Model.Race { RaceDate = new DateTime(2020, 2, 23), TournamentName = "MK8:Death Race", GrandPrixName = "Special Cup", Driver = "Tanooki", Position = 2, Points = 40 }
                    );
            }

            if (!context.News.Any())
            {
                context.News.AddOrUpdate(
                    p => p.ID,
                    new Model.News { DateEntered = new DateTime(2021, 3, 7), NewsTitle = "How fast can one go?", NewsStory = "Rocket fast with drift!" }
                    );
            }

            if (!context.Announcements.Any())
            {
                context.Announcements.AddOrUpdate(
                    p => p.ID,
                    new Model.Announcement { DateEntered = new DateTime(2021, 3, 7), Title = "Tournament", TournamentName = "MK10: Return of the Toad", TournamentDate = new DateTime(2021, 3, 7), TournamentTime = new DateTime(2021, 3, 7, 5, 0, 0), TournamentCallTime = new DateTime(2021, 3, 7, 5, 15, 0), Story = "Can he do it?" }
                    );
            }

            context.SaveChanges();
        }
    }
}