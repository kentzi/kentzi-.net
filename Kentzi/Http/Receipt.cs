using System;
using RestSharp;
using RestSharp.Validation;
using RestSharp.Serializers;

namespace Kentzi
{
	public partial class KentziClient
	{

		public virtual KentziReceipt SendReceipt(KentziReceipt receipt)
		{
			Require.Argument("receipt", receipt);

            var request = new RestRequest(Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.JsonSerializer = new JsonSerializer();
			request.Resource = "receipts/";
            request.AddBody(receipt);

			return Execute<KentziReceipt>(request);
		}
		  
	}
}