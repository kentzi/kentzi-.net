using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kentzi.Model
{
    public class KentziReceipt
    {

        private int retailStoreId;
        private int workstationId;
        private int sequenceNumber;
        private String timestamp;
        private List<KentziItem> kentziItems;
        private KentziUser kentziUser;

        public List<KentziItem> KentziItems
        {
            get { return kentziItems; }
            set { kentziItems = value; }
        }


        public KentziUser KentziUser
        {
            get { return kentziUser; }
            set { kentziUser = value; }
        }

        public int RetailStoreID
        {
            get { return retailStoreId; }
            set { retailStoreId = value; }
        }

        public int WorkStationID
        {
            get { return workstationId; }
            set { workstationId = value; }
        }

        public int SequenceNumber
        {
            get { return sequenceNumber; }
            set { sequenceNumber = value; }
        }

        public String MyProperty
        {
            get { return timestamp; }
            set { timestamp = value; }
        }

    }

}