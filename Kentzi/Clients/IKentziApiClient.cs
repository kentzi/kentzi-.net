using System;

namespace Kentzi
{
	public interface IKentziApiClient
	{
		KentzirestClient RestClient { get; }
	}
}

