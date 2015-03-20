using System;
using RestSharp;

namespace Kentzi
{
	public class KentziRestClient : IKentziRestClient
	{

		public static readonly Uri KentziApiUrl = new Uri("http://kentzi.herokuapp.com/api/");
		
		public KentziRestClient(){
			RestClient = new RestClient(KentziApiUrl);
		}
		
		public RestClient RestClient { get; }
	}


}

