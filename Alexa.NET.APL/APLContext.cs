using Alexa.NET.Request;
using Newtonsoft.Json;

namespace Alexa.NET.APL
{
    public class APLContext:Context
    {
        [JsonProperty("Display")]
        public AlexaDisplay Display { get; set; }

        [JsonProperty("Viewport")]
        public AlexaViewport Viewport { get; set; }

        [JsonProperty("Viewports")]
        public Viewport[] Viewports { get; set; }
    }
}