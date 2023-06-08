using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAssitant.Core.Entities
{
    public class Departure
    {
        public string Airport { get; set; }
        public string Timezone { get; set; }
        public string Iata { get; set; }
        public string Icao { get; set; }
        public object Terminal { get; set; }
        public object Gate { get; set; }
        public object Delay { get; set; }
        public DateTime Scheduled { get; set; }
        public DateTime Estimated { get; set; }
        public object Actual { get; set; }
        public object EstimatedRunway { get; set; }
        public object ActualRunway { get; set; }
    }
}
