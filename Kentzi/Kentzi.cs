using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kentzi.Utils;

namespace Kentzi
{
    public class KentziClient
    {

        public const string BASE_URL = "http://kentzi.herokuapp.com/api/";

        public void doRequest()
        {
            var client = GetRestClient();

            var request = new RestRequest("users/{id}/", Method.GET);

            request.AddUrlSegment("id", "1");


            // execute the request
            IRestResponse response = client.Execute(request);
            var content = response.Content; // raw content as string
            Console.WriteLine(content);
        }

        public void CreateKentziUser(String name, String email, String birthdate) {

            var client = GetRestClient();
            var request = new RestRequest("users/", Method.POST);

            request.AddParameter("email", email);
            request.AddParameter("name", name + " - " + Utils.Utils.GetTimestamp(System.DateTime.Now));
            request.AddParameter("birthdate", birthdate);
            // execute the request
            IRestResponse response = client.Execute(request);
            var content = response.Content; // raw content as string
            Console.WriteLine(content);

        }

        private RestClient GetRestClient()
        {
            return new RestClient(BASE_URL);
        }

    }
}