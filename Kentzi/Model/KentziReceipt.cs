using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kentzi.Model
{
    public class KentziReceipt
    {
        public String mobileNumber { get; set; }
        public string StoreId { get; set; }
        public string ReceiptCode { get; set; }
        public double Amount { get; set; }
        public double discount { get; set; }
        public string hostName { get; set; }
        public DateTime date { get; set; }
        public List<KentziLineItem> lineItems { get; set; }
    }
}
