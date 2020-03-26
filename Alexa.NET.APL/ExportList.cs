using Newtonsoft.Json;

namespace Alexa.NET.Response.APL
{
    public class ExportList
    {
        [JsonProperty("graphics",NullValueHandling = NullValueHandling.Ignore)]
        public Export[] Graphics { get; set; }

        [JsonProperty("layouts",NullValueHandling = NullValueHandling.Ignore)]
        public Export[] Layouts { get; set; }

        [JsonProperty("resources",NullValueHandling = NullValueHandling.Ignore)]
        public Export[] Resources{ get; set; }

        [JsonProperty("styles",NullValueHandling = NullValueHandling.Ignore)]
        public Export[] Styles { get; set; }
    }
}