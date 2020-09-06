using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.API.Data.Standings
{
    // StandingsList myDeserializedClass = JsonConvert.DeserializeObject<StandingsList>(myJsonResponse); 
    public class Standings
    {
        public int position { get; set; }
        public string driverName { get; set; }
        public int grandPrixDriven { get; set; }
        public int grandPrixTotal { get; set; }
        public int writersCorner { get; set; }
        public int points { get; set; }
    }
}
