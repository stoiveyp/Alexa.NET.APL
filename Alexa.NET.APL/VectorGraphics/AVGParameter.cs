using Newtonsoft.Json;

namespace Alexa.NET.APL.VectorGraphics
{
    public class AVGParameter
    {
        [JsonProperty("name")]
        public APLValue<string> Name { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Description { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<AVGParameterType> Type { get; set; }

        [JsonProperty("default",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Default { get; set; }
    }
}