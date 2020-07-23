using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Audio.Filters
{
    public class FadeIn : APLAFilter
    {
        public override string Type => nameof(FadeIn);

        [JsonProperty("duration")]
        public APLValue<int> Duration { get; set; }
    }
}