using System;

namespace Kentzi
{
	public abstract class KentziBase
	{
		/// <summary>
		/// Exception encountered during API request
		/// </summary>
		public RestException RestException { get; set; }

		/// <summary>
		/// The URI for this resource, relative to https://api.twilio.com
		/// </summary>
		public Uri Uri { get; set; }
	}
}

