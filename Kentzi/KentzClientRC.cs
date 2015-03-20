using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kentzi
{
    class KentzClientRC : IKentziRestClient
    {
        public RestSharp.RestClient KentziRestClient
        {
            get { throw new NotImplementedException(); }
        }

        public IStoresClient Store
        {
            get { throw new NotImplementedException(); }
        }
    }
}
