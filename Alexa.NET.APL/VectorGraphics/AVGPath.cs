using Newtonsoft.Json;

namespace Alexa.NET.APL.VectorGraphics
{
    public class AVGPath : IAVGItem
    {
        [JsonProperty("type")] public string Type => "path";

        [JsonProperty("fillOpacity",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<double?> FillOpacity { get; set; }

        [JsonProperty("fill",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Fill { get; set; }

        [JsonProperty("pathData",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> PathData { get; set; }

        [JsonProperty("strokeOpacity",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<double?> StrokeOpacity { get; set; }

        [JsonProperty("stroke",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Stroke { get; set; }

        [JsonProperty("strokeWidth",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int> StrokeWidth { get; set; }


    }
}