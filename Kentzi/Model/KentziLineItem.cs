using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kentzi
{
    public class KentziLineItem
    {
		public KentziLineItem (string receipt, string code, string name, string description, double price, double tax, int quantity)
    	{
			this.receipt = receipt;
    		this.code = code;
    		this.name = name;
    		this.description = description;
    		this.price = price;
    		this.tax = tax;
    		this.quantity = quantity;
    	}
    	
		public string receipt { get; set; }
        public string code { get; set; }
		public string name { get; set; }
		public string description { get; set; }
		public double price { get; set; }
		public double tax { get; set; }
		public int quantity { get; set; }                
    }
}
