using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Alexa.NET.APL.DataSources
{

    public class ObjectDataSource:APLDataSource
    {
        public const string DataSourceType = "object";
        [JsonProperty("type")] public override string Type => DataSourceType;

        [JsonProperty("description",NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("objectID", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectId { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("properties")]
        public virtual Dictionary<string,object> Properties { get; set; }

        [JsonExtensionData]
        public virtual Dictionary<string, object> TopLevelData { get; set; }

        [JsonProperty("transformers",NullValueHandling = NullValueHandling.Ignore)]
        public IList<APLTransformer> Transformers { get; set; }
    }
}
