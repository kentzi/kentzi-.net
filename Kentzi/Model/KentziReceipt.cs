using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kentzi.Model
{
    public class KentziReceipt
    {
        public String MobileNumber { get; set; }
        public string StoreId { get; set; }
        public string ReceiptCode { get; set; }
        public double Amount { get; set; }
        public double Discount { get; set; }
        public string HostName { get; set; }
        public DateTime Date { get; set; }
        public List<KentziLineItem> lineItems { get; set; }
    }
}
