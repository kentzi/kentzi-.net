using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kentzi.Model
{
    public class KentziLineItem
    {
        private string Code { get; set; }
        private string Name { get; set; }
        private string Description { get; set; }
        private double Price { get; set; }
        private double Tax { get; set; }
        private int Quantity { get; set; }                
    }
}
