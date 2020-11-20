using Newtonsoft.Json;

namespace Alexa.NET.APL.Filters
{
    public class Grayscale : IImageFilter
    {
        [JsonProperty("type")]
        public string Type => nameof(Grayscale);

        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<double?> Amount { get; set; }

        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> Source { get; set; }
    }
}