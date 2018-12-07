using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Alexa.NET.APL.DataSources
{
    public class ObjectDataSource:APLDataSource
    {
        [JsonProperty("type")] public override string Type => "object";

        [JsonProperty("description",NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("objectID", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectId { get; set; }

        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string,object> Properties { get; set; }

        [JsonProperty("transformers",NullValueHandling = NullValueHandling.Ignore)]
        public IList<APLTransformer> Transformers { get; set; }
    }
}
