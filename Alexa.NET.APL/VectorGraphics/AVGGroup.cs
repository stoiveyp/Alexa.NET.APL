using System.Collections.Generic;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL.VectorGraphics
{
    public class AVGGroup : AVGItem
    {
        [JsonProperty("type")] public override string Type => "group";

        [JsonProperty("opacity",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<double?> Opacity { get; set; }

        [JsonProperty("style", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Style { get; set; }

        [JsonProperty("clipPath",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ClipPath { get; set; }

        [JsonProperty("transform",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Transform { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(AVGItemListConverter))]
        public APLValue<IList<IAVGItem>> Items { get; set; }

    }
}