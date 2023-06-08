﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAssitant.Core.Entities
{
    public class Flight
    {
        public string Number { get; set; }
        public string Iata { get; set; }
        public string Icao { get; set; }
        public object Codeshared { get; set; }
    }
}
