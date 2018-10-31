using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Alexa.NET.APL.DataSources
{
    public class ObjectDataSource:APLDataSource
    {
        [JsonProperty("type")]
        public override string Type { get; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("objectID")]
        public string ObjectId { get; set; }

        [JsonProperty("properties")]
        public Dictionary<string,object> Properties { get; set; }
    }
}
