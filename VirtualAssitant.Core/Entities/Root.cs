using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAssitant.Core.Entities
{
    public class Root
    {
        public Pagination Pagination { get; set; }
        public List<Data> Data { get; set; }
    }
}
