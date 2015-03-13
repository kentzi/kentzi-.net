using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kentzi.Model
{
    class KentziLineItem
    {
        private string code;
        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        private double tax;
        public double Tax
        {
            get { return tax; }
            set { tax = value; }
        }

        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }        
                
    }
}
