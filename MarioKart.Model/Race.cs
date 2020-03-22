using System;


namespace MarioKart.Model
{
    public class Race
    {
        public int ID { get; set; }
        public DateTime? RaceDate { get; set; }
        public string TournamentName { get; set; }
        public string GrandPrixName { get; set; }
        public string Driver { get; set; }
        public int Position { get; set; }
        public int Points { get; set; }
    }
}