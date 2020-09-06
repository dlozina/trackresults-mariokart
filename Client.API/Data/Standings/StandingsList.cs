using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.API.Data.Standings
{
    // StandingsList myDeserializedClass = JsonConvert.DeserializeObject<StandingsList>(myJsonResponse);
    public class StandingsList
    {
        public List<Standings> Standings { get; set; }
    }
}
