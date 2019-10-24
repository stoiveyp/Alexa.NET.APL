using Alexa.NET.Response.APL;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.APL
{
    public class APLTViewport : Viewport
    {
        public override string Type => "APLT";

        [JsonProperty("supportedProfiles")]
        public APLTProfile[] SupportedProfiles { get; set; }

        [JsonProperty("lineLength")]
        public int LineLength { get; set; }

        [JsonProperty("lineCount")]
        public int LineCount { get; set; }

        [JsonProperty("format")]
        [JsonConverter(typeof(StringEnumConverter))]
        public APLTFormat Format { get; set; }

        [JsonProperty("interSegments")]
        public InterSegment[] InterSegments { get; set; }
    }
}