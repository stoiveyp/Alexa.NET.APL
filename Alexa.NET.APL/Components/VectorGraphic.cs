using System.Collections.Generic;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class VectorGraphic: TouchComponent
    {
        [JsonProperty("type")]
        public override string Type => nameof(VectorGraphic);

        [JsonProperty("align",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Align { get; set; }

        [JsonProperty("scale", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<Scale> Scale { get; set; }

        [JsonProperty("source",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Source { get; set; }

        [JsonProperty("onLoad", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter), true)]
        public APLValue<IList<APLCommand>> OnLoad { get; set; }

        [JsonProperty("onFail", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter), true)]
        public APLValue<IList<APLCommand>> OnFail { get; set; }
    }
}
