using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kentzi.Model
{

    public class KentziItem
    {

        private long itemId;
        private String longName;
        private String shortName;
        private double itemPrice;
        private double itemTax;
        private double quantity;

        public long ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }

        public String LongName
        {
            get { return longName; }
            set { longName = value; }
        }

        public String ShortName
        {
            get { return shortName; }
            set { shortName = value; }
        }

        public double ItemPrice
        {
            get { return itemPrice; }
            set { itemPrice = value; }
        }

        public double ItemTax
        {
            get { return itemTax; }
            set { itemTax = value; }
        }

        public double Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
}