using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAssitant.Core.Entities
{
    internal class MyEvent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly EventDate { get; set; }
        public string FLightNumber { get; set; }
        public Flight Flight { get; set; }
    }
}
