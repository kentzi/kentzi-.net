using System;
using RestSharp;

namespace Kentzi
{
	public interface IKentziRestClient
	{
		RestClient RestClient { get; }
	}
}

