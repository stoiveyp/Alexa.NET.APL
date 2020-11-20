using Newtonsoft.Json;

namespace Alexa.NET.APL.Filters
{
    public class Gradient : IImageFilter
    {
        [JsonProperty("type")]
        public string Type => nameof(Gradient);

        [JsonProperty("gradient",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<APLGradient> SelectedGradient { get; set; }
    }
}