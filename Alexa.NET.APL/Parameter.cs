using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.Response.APL
{
    public class Parameter
    {
        public Parameter() { }

        public Parameter(string name)
        {
            Name = name;
        }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type"),JsonConverter(typeof(StringEnumConverter))]
        public ParameterType Type { get; set; }

        public bool ShouldSerializeType()
        {
            return Type != ParameterType.any;
        }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
        public object Default { get; set; }
    }
}