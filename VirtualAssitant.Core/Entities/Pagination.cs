using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAssitant.Core.Entities
{
    public class Pagination
    {
        public int Limit { get; set; }
        public int Offset { get; set; }
        public int Count { get; set; }
        public int Total { get; set; }
    }
}
