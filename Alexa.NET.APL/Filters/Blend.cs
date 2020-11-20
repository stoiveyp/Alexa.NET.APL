using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Filters
{
    public class Blend : IImageFilter
    {
        [JsonProperty("type")]
        public string Type => nameof(Blend);

        [JsonProperty("destination", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> Destination { get; set; }

        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> Source { get; set; }

        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(APLValueEnumConverter<BlendMode>))]
        public APLValue<BlendMode?> Mode { get; set; }
    }
}