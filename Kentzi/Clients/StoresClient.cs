using System;

namespace Kentzi
{
    public class StoresClient : ApiClient, IStoresClient
	{
		public StoresClient Get(string storeId){
            return KentziRestClient.Execute<StoresClient>(new RestRequest("stores/{id}", Method.GET).AddUrlSegment("id", storeId)).Data;
		}
	}
}