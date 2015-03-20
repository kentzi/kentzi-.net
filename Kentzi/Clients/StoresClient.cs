using System;

namespace Kentzi
{
	public class StoresClient : KentziRestClient
	{
		public StoresClient Get(string storeId){
			return RestClient.Execute<StoresClient>(new RestRequest("stores/{id}", Method.GET).AddUrlSegment("id", storeId)).Data;
		}
	}
}