using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kentzi.Model
{

    public class KentziItem
    {
        public long ItemId { get; set; }
        public String LongName { get; set; }
        public String ShortName { get; set; }
        public double ItemPrice { get; set; }
        public double ItemTax { get; set; }
        public double Quantity { get; set; }
    }
}