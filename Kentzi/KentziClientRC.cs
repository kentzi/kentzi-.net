using System;
using RestSharp;

namespace Kentzi
{
	public abstract class KentziClient
	{

		/// <summary>
		/// Base URL of the Kentzi API
		/// </summary>
		public string BaseUrl { get; private set; }

		/// <summary>
		/// StoreId
		/// </summary>
		protected string StoreId { get; set; }

		protected RestClient _client;


		/// <summary>
		/// Initializes a new client with the specified credentials.
		/// </summary>
		/// <param name="storeId">The Id assigned to each store</param>
		/// <param name="baseUrl">Base URL of the Kentzi API</param>
		public KentziClient(string storeId, string baseUrl){
			StoreId = storeId;
			BaseUrl = baseUrl;

			_client = new RestClient();
			_client.UserAgent = "kentzi-csharp/" + version + " (.NET " + Environment.Version.ToString() + ")";
			_client.AddDefaultHeader("Accept-charset", "utf-8");
			_client.BaseUrl = BaseUrl;
			_client.Timeout = 30500;
		}


		/// <summary>
		/// Execute a manual REST request
		/// </summary>
		/// <typeparam name="T">The type of object to create and populate with the returned data.</typeparam>
		/// <param name="request">The RestRequest to execute (will use client credentials)</param>
		public virtual T Execute<T>(IRestRequest request) where T : new()
		{
			request.OnBeforeDeserialization = (resp) =>
			{
				// for individual resources when there's an error to make
				// sure that RestException props are populated
				if (((int)resp.StatusCode) >= 400)
				{
					// have to read the bytes so .Content doesn't get populated
					string restException = "{{ \"RestException\" : {0} }}";
					var content = resp.RawBytes.AsString(); //get the response content
					var newJson = string.Format(restException, content);

					resp.Content = null;
					resp.RawBytes = Encoding.UTF8.GetBytes(newJson.ToString());
				}
			};

			var response = _client.Execute<T>(request);
			return response.Data;
		}

	}
}