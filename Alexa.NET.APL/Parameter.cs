using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.Response.APL
{
    public class Parameter
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type"),JsonConverter(typeof(StringEnumConverter))]
        public ParameterType Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        public object Default { get; set; }
    }
}