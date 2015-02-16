using Kentzi.Model;
using Kentzi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KentziTest
{
    class KentziTest
    {
        static int Main(string[] args)
        {
            KentziClient kc = new KentziClient();
            kc.CreateKentziUser("lalongooo3");
            
            return 0;
        }
    }
}