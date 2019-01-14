using System.Collections.Generic;
using Alexa.NET.APL;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.Response.APL
{
    public class APLDocument
    {
        [JsonProperty("type")]
        public string Type => "APL";

        [JsonProperty("version")]
        public string Version => "1.0";

        [JsonProperty("theme",NullValueHandling = NullValueHandling.Ignore),JsonConverter(typeof(StringEnumConverter))]
        public ViewportTheme Theme { get; set; }

        [JsonProperty("mainTemplate")]
        public Layout MainTemplate { get; set; }

        [JsonProperty("import", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Import> Imports { get; set; }

        [JsonProperty("layouts", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string,Layout> Layouts { get; set; }

        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Resource> Resources { get; set; }

        [JsonProperty("styles", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string,Style> Styles { get; set; }
}
}