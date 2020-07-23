using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Audio
{
    public class Silence : APLAComponent
    {
        public override string Type => nameof(Silence);

        [JsonProperty("duration",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> Duration { get; set; }
    }
}