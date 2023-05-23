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
            var raw = Utility.ExampleFileContent<DataStoreCommand>("DataStore_PutObject.json");
            var cmd = Assert.IsType<PutObject>(raw);
            Assert.NotNull(cmd.Content);
            Assert.Equal("mainPage", cmd.Key);
            Assert.Equal("objectDataStoreExample", cmd.Namespace);
            Assert.Equal("Secondary text from the data store", cmd.Content.Value<string>("secondaryText"));
        }

        [Fact]
        public void PutObjectArrayCommand()
        {
            var raw = Utility.ExampleFileContent<DataStoreCommand>("DataStore_PutObjectArray.json");
            var cmd = Assert.IsType<PutObjectArray>(raw);
            Assert.NotNull(cmd.Content);
            Assert.Equal(4, cmd.Content.Length);
            Assert.Equal("arrayDataStoreExample", cmd.Namespace);
            Assert.Equal("mainList", cmd.Key);
            var firstItem = cmd.Content[0];
            Assert.Equal("The first list item.", firstItem.Value<string>("primaryText"));
        }
    }
}
