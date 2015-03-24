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
				new KentziLineItem("0000001", "1000","Coke", "Coke 500 ml", 10.0, 2.0, 3)
			};

			KentziReceipt o = new KentziReceipt ("8116916048", kentzi.StoreId, "0000001", 99.0, 10.0, "localhost", DateTime.Now, lineItems);
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