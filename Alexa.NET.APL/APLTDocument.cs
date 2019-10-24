using Alexa.NET.APL;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.Response.APL
{
    public class APLTDocument : APLDocumentBase
    {
        public override string Type => "APLT";

        [JsonProperty("targetProfile",NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public APLTProfile? TargetProfile { get; set; }

        public APLTDocument():base(APLDocumentVersion.V1)
        {

        }
    }
}