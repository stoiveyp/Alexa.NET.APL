using System.Collections.Generic;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL.VectorGraphics
{
    public class AVGGroup : IAVGItem
    {
        [JsonProperty("type")] public string Type => "group";

        [JsonProperty("opacity",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<double?> Opacity { get; set; }

        [JsonProperty("rotation", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<double?> Rotation { get; set; }

        [JsonProperty("pivotX", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> PivotX { get; set; }

        [JsonProperty("pivotY", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> PivotY { get; set; }

        [JsonProperty("scaleX", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<double?> ScaleX { get; set; }

        [JsonProperty("scaleY", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<double?> ScaleY { get; set; }

        [JsonProperty("translateX", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> TranslateX { get; set; }

        [JsonProperty("translateY", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> TranslateY { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore),
        JsonConverter(typeof(AVGItemListConverter))]
        public APLValue<IList<IAVGItem>> Items { get; set; }

    }
}