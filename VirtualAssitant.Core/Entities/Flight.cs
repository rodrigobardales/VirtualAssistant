using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAssitant.Core.Entities
{
    public class Flight
    {
        public int Id { get; set; }
        public string FlightNumber { get; set; }
        public string Airline { get; set; }
        public DateOnly FlightDate { get; set; }
        public string FligthState { get; set; }
        public string Origin { get; set; }
        public string Destiny { get; set; }
        public int Capacity { get; set; }
        public Category Category { get; set; }
    }
}
