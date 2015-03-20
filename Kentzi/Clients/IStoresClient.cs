using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kentzi
{
    public interface IStoresClient
    {
        KentziStore Get(string storeId);
    }
}
