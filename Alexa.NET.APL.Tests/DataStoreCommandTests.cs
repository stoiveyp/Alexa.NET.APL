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
            var raw = new JObject(new JProperty("namespace", "test"),new JProperty("type", "PUT_NAMESPACE"));
            var cmd = Assert.IsType<PutNamespace>(JsonConvert.DeserializeObject<DataStoreCommand>(raw.ToString()));
            Assert.Equal("test", cmd.Namespace);
            Assert.Equal(JObject.FromObject(cmd).ToString(), raw.ToString());
        }

        [Fact]
        public void RemoveNamespaceCommand()
        {
            var raw = new JObject(new JProperty("namespace", "test"), new JProperty("type", "REMOVE_NAMESPACE"));
            var cmd = Assert.IsType<RemoveNamespace>(JsonConvert.DeserializeObject<DataStoreCommand>(raw.ToString()));
            Assert.Equal("test", cmd.Namespace);
            Assert.Equal(JObject.FromObject(cmd).ToString(), raw.ToString());
        }

        [Fact]
        public void ClearCommand()
        {
            var raw = new JObject(new JProperty("type", "CLEAR"));
            var cmd = Assert.IsType<Clear>(JsonConvert.DeserializeObject<DataStoreCommand>(raw.ToString()));
            Assert.Equal(JObject.FromObject(cmd).ToString(), raw.ToString());
        }

        [Fact]
        public void PutObjectCommand()
        {
            var raw = Utility.ExampleFileContent<DataStoreCommand>("DataStore_PutObject.json");
            var cmd = Assert.IsType<PutObject>(raw);
            Utility.CompareJson(cmd, "DataStore_PutObject.json");
        }

        [Fact]
        public void PutObjectArrayCommand()
        {
            var raw = Utility.ExampleFileContent<DataStoreCommand>("DataStore_PutObjectArray.json");
            var cmd = Assert.IsType<PutObjectArray>(raw);
            Utility.CompareJson(cmd, "DataStore_PutObjectArray.json");
        }
    }
}
