using Alexa.NET.APL.DataStore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xunit;

namespace Alexa.NET.APL.Tests
{
    public class DataStoreCommandTests
    {
        [Fact]
        public void PutNamespaceCommand()
        {
            var raw = new JObject(new JProperty("type", "PUT_NAMESPACE"), new JProperty("namespace", "test"));
            var cmd = Assert.IsType<PutNamespace>(JsonConvert.DeserializeObject<DataStoreCommand>(raw.ToString()));
            Assert.Equal("test", cmd.Namespace);
        }

        [Fact]
        public void RemoveNamespaceCommand()
        {
            var raw = new JObject(new JProperty("type", "REMOVE_NAMESPACE"), new JProperty("namespace", "test"));
            var cmd = Assert.IsType<RemoveNamespace>(JsonConvert.DeserializeObject<DataStoreCommand>(raw.ToString()));
            Assert.Equal("test", cmd.Namespace);
        }

        [Fact]
        public void ClearCommand()
        {
            var raw = new JObject(new JProperty("type", "CLEAR"));
            var cmd = Assert.IsType<Clear>(JsonConvert.DeserializeObject<DataStoreCommand>(raw.ToString()));
        }

        [Fact]
        public void PutObjectCommand()
        {
            var raw = new JObject(new JProperty("type", "PUT_OBJECT"), new JProperty("content",new JObject(new JProperty("test",123))));
            var cmd = Assert.IsType<PutObject>(JsonConvert.DeserializeObject<DataStoreCommand>(raw.ToString()));
            Assert.NotNull(cmd.Content);
            Assert.Equal(123, cmd.Content.Value<int>("test"));
        }
    }
}
