using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Filters
{
    public class Noise : IImageFilter
    {
        [JsonProperty("type")]
        public string Type => nameof(Noise);

        [JsonProperty("useColor", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> UseColor { get; set; }

        [JsonProperty("sigma", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> Sigma { get; set; }

        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(APLValueEnumConverter<NoiseKind>))]
        public APLValue<NoiseKind?> Kind { get; set; }
    }
}