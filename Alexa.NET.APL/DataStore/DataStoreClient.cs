using Alexa.NET.Request;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Alexa.NET.APL.DataStore
{
    public class DataStoreClient
    {
        public HttpClient Client { get; }
        public Uri BaseAddress { get; }
        private string Token { get; }

        public DataStoreClient(SkillRequest request) : this(
            request.Context.System.ApiEndpoint,
            request.Context.System.ApiAccessToken)
        {
        }

        public DataStoreClient(string endpointUrl, string accessToken):this(null, endpointUrl, accessToken)
        {
            
        }

        public DataStoreClient(HttpClient client, string endpointUrl, string accessToken)
        {
            Client = client ?? new HttpClient();
            BaseAddress = new Uri(endpointUrl);
            Token = accessToken;
        }

        public async Task<bool> Cancel(string queuedResultId)
        {
            var url = $"/v1/datastore/queue/{queuedResultId}/cancel";
            var msg = new HttpRequestMessage(HttpMethod.Post, new Uri(BaseAddress, url))
            {
                Content = new StringContent(string.Empty, Encoding.UTF8, "application/json")
            };
            var response = await Client.SendAsync(msg);
            return response.StatusCode == HttpStatusCode.NoContent;
        }
    }
}
