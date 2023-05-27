using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Alexa.NET.APL.DataStore
{
    public class AccessTokenClient
    {
        public const string ApiDomainBaseAddress = "https://api.amazon.com";
        public const string DataStoreScope = "alexa::datastore";
        public const string ClientCredentials = "client_credentials";

        public HttpClient Client { get; set; }
        private static readonly JsonSerializer Serializer = JsonSerializer.Create();


        private string BaseAddress { get; }

        public AccessTokenClient():this(new HttpClient(),null){}

        public AccessTokenClient(string baseAddress) : this(null, baseAddress){}

        public AccessTokenClient(HttpClient client):this(client,null){}

        public AccessTokenClient(HttpClient client, string baseAddress)
        {
            BaseAddress = baseAddress ?? ApiDomainBaseAddress;
            Client = client ?? new HttpClient();
        }

        public async Task<AccessToken> Send(string clientId, string clientSecret)
        {
            var content = new FormUrlEncodedContent(new Dictionary<string, string>
            {
                {"client_id",clientId},
                {"client_secret",clientSecret},
                {"grant_type",ClientCredentials},
                {"scope",DataStoreScope}
            });


            var msg = new HttpRequestMessage(HttpMethod.Post, new Uri(new Uri(BaseAddress), "/auth/O2/token")){Content = content};
            var response = await Client.SendAsync(msg);
            using (var reader = new JsonTextReader(new StreamReader(await response.Content.ReadAsStreamAsync())))
            {
                return Serializer.Deserialize<AccessToken>(reader);
            }
        }
    }

    public class AccessToken

    {

        [JsonProperty("access_token")]

        public string Token { get; set; }



        [JsonProperty("expires_in")]

        public int ExpiresIn { get; set; }



        [JsonProperty("scope")]

        public string Scope { get; set; }



        [JsonProperty("token_type")]

        public string TokenType { get; set; }

    }
}
