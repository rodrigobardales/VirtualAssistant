using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAssitant.Core.Entities
{
    public class Data
    {
        public string FlightDate { get; set; }
        public string FlightStatus { get; set; }
        public Departure Departure { get; set; }
        public Arrival Arrival { get; set; }
        public Airline Airline { get; set; }
        public Flight Flight { get; set; }
        public object Aircraft { get; set; }
        public object Live { get; set; }
    }
}
