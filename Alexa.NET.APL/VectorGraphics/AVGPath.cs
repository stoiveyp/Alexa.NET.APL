using System.Collections.Generic;
using System.Runtime.Serialization;
using Alexa.NET.APL.JsonConverter;
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

        [JsonProperty("fillTransform",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> FillTransform { get; set; }

        [JsonProperty("pathData",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> PathData { get; set; }

        [JsonProperty("pathLength",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> PathLength { get; set; }

        [JsonProperty("stroke", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Stroke { get; set; }

        [JsonProperty("strokeDashArray",NullValueHandling = NullValueHandling.Ignore),
            JsonConverter(typeof(GenericSingleOrListConverter<APLValue<int?>>))]
        public APLValue<IList<APLValue<int?>>> StrokeDashArray { get; set; }

        [JsonProperty("strokeDashOffset",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> StrokeDashOffset { get; set; }

        [JsonProperty("strokeLineCap",NullValueHandling = NullValueHandling.Ignore),
            JsonConverter(typeof(APLValueEnumConverter<StrokeLineCap>))]
        public APLValue<StrokeLineCap?> StrokeLineCap { get; set; }

        [JsonProperty("strokeLineJoin", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLValueEnumConverter<StrokeLineJoin>))]
        public APLValue<StrokeLineJoin?> StrokeLineJoin { get; set; }

        [JsonProperty("strokeMiterLimit",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> StrokeMiterLimit { get; set; }

        [JsonProperty("strokeOpacity",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<double?> StrokeOpacity { get; set; }
        
        [JsonProperty("strokeWidth",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> StrokeWidth { get; set; }

        [JsonProperty("strokeTransform",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> StrokeTransform { get; set; }

        [JsonProperty("style",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Style { get; set; }


    }

    public enum StrokeLineJoin
    {
        [EnumMember(Value="bevel")]
        Bevel,
        [EnumMember(Value="miter")]
        Miter,
        [EnumMember(Value="round")]
        Round
    }

    public enum StrokeLineCap
    {
        [EnumMember(Value="butt")]
        Butt,
        [EnumMember(Value="round")]
        Round,
        [EnumMember(Value="square")]
        Square
    }
}