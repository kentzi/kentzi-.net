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
			request.Resource = "receipts/";
			request.AddParameter("application/json; charset=utf-8", new JsonSerializer().Serialize (receipt), ParameterType.RequestBody);
			request.RequestFormat = DataFormat.Json;

			return Execute<KentziReceipt>(request);
		}
		  
	}
}

