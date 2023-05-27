using Alexa.NET.Request;
using System;
using System.IO;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alexa.NET.APL.DataStore
{
    public class DataStoreClient
    {
        public HttpClient Client { get; }
        public Uri BaseAddress { get; }
        private string Token { get; }

        private JsonSerializer Serializer = JsonSerializer.Create();

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

        public Task<QueuedResultResponse> QueuedResultQuery(string queuedResultId, int maxResults)
        {
            return QueuedResultQuery(queuedResultId, maxResults, null);
        }

        public async Task<QueuedResultResponse> QueuedResultQuery(string queuedResultId, int? maxResults = null, string nextToken = null)
        {
            var url = $"/v1/datastore/queue/{queuedResultId}";
            var query = "";
            if (maxResults != null || !string.IsNullOrWhiteSpace(nextToken))
            {
                query = "?";
                if (maxResults != null)
                {
                    query += "maxResults=";
                    query += maxResults.ToString();
                }

                if (!string.IsNullOrWhiteSpace(nextToken))
                {
                    if (query.Length > 1)
                    {
                        query += "&";
                    }

                    query += "nextToken=";
                    query += nextToken;
                }
            }

            var msg = new HttpRequestMessage(HttpMethod.Get, new Uri(BaseAddress, url + query));
            msg.Headers.Authorization = new AuthenticationHeaderValue("Bearer", Token);
            var response = await Client.SendAsync(msg);
            response.EnsureSuccessStatusCode();
            using var body = await response.Content.ReadAsStreamAsync();
            using var sr = new JsonTextReader(new StreamReader(body));
            return Serializer.Deserialize<QueuedResultResponse>(sr);
        }

        public async Task<CommandsResponse> Commands(CommandsRequest request)
        {
            var content = JObject.FromObject(request).ToString(Formatting.None);
            var msg = new HttpRequestMessage(HttpMethod.Post, new Uri(BaseAddress, "/v1/datastore/commands"))
            {
                Content = new StringContent(content, Encoding.UTF8, "application/json")
            };
            msg.Headers.Authorization = new AuthenticationHeaderValue("Bearer", Token);
            var response = await Client.SendAsync(msg);
            response.EnsureSuccessStatusCode();
            using var body = await response.Content.ReadAsStreamAsync();
            using var sr = new JsonTextReader(new StreamReader(body));
            return Serializer.Deserialize<CommandsResponse>(sr);
        }

        public async Task<bool> Cancel(string queuedResultId)
        {
            var url = $"/v1/datastore/queue/{queuedResultId}/cancel";
            var msg = new HttpRequestMessage(HttpMethod.Post, new Uri(BaseAddress, url))
            {
                Content = new StringContent(string.Empty, Encoding.UTF8, "application/json")
            };
            msg.Headers.Authorization = new AuthenticationHeaderValue("Bearer", Token);
            var response = await Client.SendAsync(msg);
            return response.StatusCode == HttpStatusCode.NoContent;
        }
    }
}
