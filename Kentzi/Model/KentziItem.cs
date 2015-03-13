using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kentzi.Model
{

    public class KentziItem
    {
        public long itemId { get; set; }
        public String longName { get; set; }
        public String shortName { get; set; }
        public double itemPrice { get; set; }
        public double itemTax { get; set; }
        public double quantity { get; set; }
    }
}