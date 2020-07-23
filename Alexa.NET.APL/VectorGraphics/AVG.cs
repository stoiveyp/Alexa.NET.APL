using System.Collections.Generic;
using Alexa.NET.APL.JsonConverter;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.VectorGraphics
{
    public class AVG
    {
        [JsonProperty("type")] public string Type => nameof(AVG);

        [JsonIgnore]
        public AVGVersion Version
        {
            get => EnumParser.ToEnum(VersionString, AVGVersion.Unknown);
            set => VersionString = EnumParser.ToEnumString(typeof(AVGVersion), value);
        }

        [JsonProperty("version")] public string VersionString { get; set; } = "1.1";


        [JsonProperty("description",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Description { get; set; }

        [JsonProperty("height")]
        public APLAbsoluteDimensionValue Height { get; set; }

        [JsonProperty("width")]
        public APLAbsoluteDimensionValue Width { get; set; }

        [JsonProperty("items",NullValueHandling = NullValueHandling.Ignore),
        JsonConverter(typeof(AVGItemListConverter))]
        public APLValue<IList<IAVGItem>> Items { get; set; }

        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public IList<AVGResource> Resources { get; set; }

        [JsonProperty("styles", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Style> Styles { get; set; }

        [JsonProperty("parameters",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<List<AVGParameter>> Parameters { get; set; }

        [JsonProperty("scaleTypeHeight",NullValueHandling = NullValueHandling.Ignore),
        JsonConverter(typeof(APLValueEnumConverter<AVGScaleType>))]
        public APLValue<AVGScaleType> ScaleTypeHeight { get; set; }

        [JsonProperty("scaleTypeWidth", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLValueEnumConverter<AVGScaleType>))]
        public APLValue<AVGScaleType> ScaleTypeWidth { get; set; }

        [JsonProperty("viewportHeight",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> ViewportHeight { get; set; }

        [JsonProperty("viewportWidth", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> ViewportWidth { get; set; }
    }
}
