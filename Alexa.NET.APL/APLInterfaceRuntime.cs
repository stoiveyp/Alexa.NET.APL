using Alexa.NET.APL.JsonConverter;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.Request
{
    public class APLInterfaceRuntime
    {
        [JsonProperty("maxVersion", NullValueHandling = NullValueHandling.Ignore)]
        public APLDocumentVersion MaxVersion { get; set; }

        [JsonProperty("maxVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxVersionString { get; set; }
    }
}