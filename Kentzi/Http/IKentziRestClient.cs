using System;
using RestSharp;

namespace Kentzi
{
	public interface IKentziRestClient
	{
        RestClient KentziRestClient { get; private set; }

        IStoresClient Store { get;  }
	}
}

