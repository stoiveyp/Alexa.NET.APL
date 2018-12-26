using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Alexa.NET.APL.DataSources
{
    public class ObjectDynamicDataSource:ObjectDataSource
    {
        [JsonExtensionData]
        public virtual Dictionary<string, object> Properties { get; set; }
    }

    public class ObjectDataSource:APLDataSource
    {
        internal static ObjectDataSource From(ObjectDynamicDataSource dynamic)
        {
            return new ObjectDataSource
            {
                ObjectId = dynamic.ObjectId,
                Title = dynamic.Title,
                Description = dynamic.Description,
                Properties = dynamic.Properties,
                Transformers = dynamic.Transformers
            };
        }

        [JsonProperty("type")] public override string Type => "object";

        [JsonProperty("description",NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("objectID", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectId { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("properties")]
        public virtual Dictionary<string,object> Properties { get; set; }

        [JsonProperty("transformers",NullValueHandling = NullValueHandling.Ignore)]
        public IList<APLTransformer> Transformers { get; set; }
    }
}
