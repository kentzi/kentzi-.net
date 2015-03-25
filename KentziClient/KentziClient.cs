using System;
using System.Collections.Generic;
using Kentzi;

namespace KentziTest
{
    class KentziTest
    {
        static int Main(string[] args)
        {


			var kentzi = new KentziRestClient("1");
			List<KentziLineItem> lineItems = new List<KentziLineItem> {
				new KentziLineItem("0000002", "2000","Pepsi", "Pepsi 500 ml", 20.0, 4.0, 6)
			};

			KentziReceipt o = new KentziReceipt ("8116916048", kentzi.StoreId, "0000001", 200.0, 20.0, "localhost", DateTime.Now.ToString("yyyy-MM-dd"), lineItems);
			KentziReceipt i =  kentzi.SendReceipt(o);
			Console.WriteLine(i.amount);

//			new KentziClient ().getStore ("1");

//            for (int i = 0; i < 1; i++)
//            {
//                new KentziClient().CreateKentziUser("lalongooo", "hdez.jeduardo@gmail.com", "");
//            }
            
            return 0;
        }
    }
}