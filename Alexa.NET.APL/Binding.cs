using Newtonsoft.Json;

namespace Alexa.NET.Response.APL
{
    public class Binding
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("type")]
        public ParameterType Type { get; set; } = ParameterType.any;

        public bool ShouldSerializeType()
        {
            return Type != ParameterType.any;
        }

        public Binding(string name, string value)
        {
            Name = name;
            Value = value;
        }
    }
}