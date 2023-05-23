using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Alexa.NET.APL.DataStore;
using Newtonsoft.Json.Linq;
using Xunit;

namespace Alexa.NET.APL.Tests
{
    public class DataStoreClientTests
    {
        [Fact]
        public async Task AccessTokenAsksForTheCorrectToken()
        {
            var client = new AccessTokenClient(new HttpClient(new ActionHandler(async hr => 
            {
                Assert.Equal("https://api.amazon.com/auth/O2/token",hr.RequestUri.ToString());
                var content = await hr.Content.ReadAsStringAsync();
                Assert.Equal("client_id=x&client_secret=y&grant_type=client_credentials&scope=alexa%3A%3Adatastore", content);

            },new JObject(
                new JProperty("access_token","xxx"),
                new JProperty("expires_in",3600),
                new JProperty("scope", "alexa::datastore"),
                new JProperty("token_type", "bearer")
                ))));

            var result = await client.Send("x", "y");
            Assert.Equal("xxx", result.Token);
            Assert.Equal("alexa::datastore", result.Scope);
        }

        [Fact]
        public async Task CancelMethodSendsCorrectly()
        {
            var client = new DataStoreClient(new HttpClient(new ActionHandler(async hr =>
            {
                Assert.Equal("https://example.com/v1/datastore/queue/x/cancel", hr.RequestUri.ToString());
                Assert.Equal("application/json",hr.Content.Headers.ContentType.MediaType);

            }, HttpStatusCode.NoContent)),"https://example.com","xxx");

            var result = await client.Cancel("x");
            Assert.True(result);
        }
    }
}
