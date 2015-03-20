using System;
using RestSharp;

namespace Kentzi
{
    public abstract class ApiClient
    {
        protected ApiClient(KentziApiClient restClient) {
            KentziRestClient = restClient;
        }

        protected KentziApiClient KentziRestClient { get; private set; }

        protected T Get<T>() {
            return KentziRestClient.Execute<T>(new RestRequest("stores/{id}", Method.GET).AddUrlSegment("id", "")).Content.;
        }
    }
}