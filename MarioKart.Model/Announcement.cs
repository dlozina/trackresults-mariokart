using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioKart.Model
{
    public class Announcement
    {
        public int ID { get; set; }
        public DateTime? DateEntered { get; set; }
        [MaxLength(140)]
        public string Title { get; set; }
        [MaxLength(140)]
        public string TournamentName { get; set; }
        public DateTime? TournamentDate { get; set; }
        public DateTime? TournamentTime { get; set; }
        public DateTime? TournamentCallTime { get; set; }
        [MaxLength(280)]
        public string Story { get; set; }
    }
}
