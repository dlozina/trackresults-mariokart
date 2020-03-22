using System;


namespace MarioKart.Model
{
    public class Tournament
    {
        public int ID { get; set; }
        public DateTime? RaceDate { get; set; }
        public string TournamentName { get; set; }
        public string Winer { get; set; }
        public int Points { get; set; }
    }
}