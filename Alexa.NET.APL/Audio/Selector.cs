using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Audio
{
    public class Selector : APLAMultiChildComponent
    {
        [JsonProperty("strategy",NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLValueEnumConverter<SelectorStrategy>))]
        public APLValue<SelectorStrategy?> Strategy { get; set; }

        public override string Type => "Selector";
    }
}