using Alexa.NET.Response.APL;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.Request
{
    public class APLInterfaceRuntime
    {
        [JsonProperty("maxVersion", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(StringEnumConverter))]
        public APLDocumentVersion MaxVersion { get; set; }
    }
}