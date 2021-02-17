using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Audio.Filters
{
    public class Repeat : APLAFilter
    {
        public override string Type => nameof(Repeat);

        [JsonProperty("repeatCount")]
        public APLValue<int> RepeatCount { get; set; }
    }
}