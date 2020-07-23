using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL
{
    [JsonConverter(typeof(APLDocumentConverter))]
    public abstract class APLDocumentReference
    {
        [JsonProperty("type")]
        public abstract string Type { get; }
    }
}