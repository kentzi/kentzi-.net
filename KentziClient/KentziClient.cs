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
            for (int i = 0; i < 1; i++)
            {
                new KentziClient().CreateKentziUser("lalongooo", "hdez.jeduardo@gmail.com", "");
            }
            
            return 0;
        }
    }
}