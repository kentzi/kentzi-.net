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
			_request.Resource = "receipts/";
            _request.AddBody(receipt);
            return Execute<KentziReceipt>(_request);
		}
		  
	}
}