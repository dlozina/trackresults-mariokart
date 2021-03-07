using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioKart.Model
{
    public class Driver
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FavoriteTrack { get; set; }
        public string FavoriteCar { get; set; }
        public string EntryYear { get; set; }
    }
}
