using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;

namespace Alexa.NET.APL.DataStore
{
    public class PutObject : DataStoreCommand
    {
        public const string CommandType = "PUT_OBJECT";

        public PutObject():base(CommandType){}

        [JsonProperty("content")]
        public JObject Content { get; set; }

        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }
    }

    public class PutObjectArray : DataStoreCommand
    {
        public PutObjectArray() : base(PutObject.CommandType) { }

        [JsonProperty("content")]
        public JObject[] Content { get; set; }

        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }
    }
}