using Newtonsoft.Json;

namespace Alexa.NET.APL.Filters
{
    public class Color : IImageFilter
    {
        [JsonProperty("type")]
        public string Type => nameof(Color);

        [JsonProperty("color",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> SelectedColor { get; set; }
    }
}