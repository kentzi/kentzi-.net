using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kentzi.Model
{
    public class KentziReceipt
    {
        public KentziReceipt(string mobileNumber, string storeId, string receiptCode, double amount, double discount, string hostName, DateTime dateTime, List<KentziLineItem> lineItems)
        {
            this.MobileNumber = mobileNumber;
            this.StoreId = storeId;
            this.ReceiptCode = receiptCode;
            this.Amount = amount;
            this.Discount = discount;
            this.HostName = hostName;
            this.DateTime = dateTime;
            this.LineItems = lineItems;
        }
        

        public String MobileNumber { get; set; }
        public string StoreId { get; set; }
        public string ReceiptCode { get; set; }
        public double Amount { get; set; }
        public double Discount { get; set; }
        public string HostName { get; set; }
        public DateTime DateTime { get; set; }
        public List<KentziLineItem> LineItems { get; set; }
    }
}
