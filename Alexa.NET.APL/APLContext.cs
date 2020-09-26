using Alexa.NET.Request;
using Newtonsoft.Json;

namespace Alexa.NET.APL
{
    public class APLContext:Context
    {
        [JsonProperty("Display", NullValueHandling = NullValueHandling.Ignore)]
        public AlexaDisplay Display { get; set; }

        [JsonProperty("Viewport", NullValueHandling = NullValueHandling.Ignore)]
        public AlexaViewport Viewport { get; set; }

        [JsonProperty("Viewports", NullValueHandling = NullValueHandling.Ignore)]
        public Viewport[] Viewports { get; set; }

        [JsonProperty("Extensions",NullValueHandling = NullValueHandling.Ignore)]
        public AlexaExtensions Extensions { get; set; }


    }
}