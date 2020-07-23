using Alexa.NET.APL.JsonConverter;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class AlexaSlider : AlexaSliderBase
    {
        public override string Type => nameof(AlexaSlider);

        [JsonProperty("sliderId")]
        public APLValue<string> SliderId { get; set; }

        [JsonProperty("metadataPosition", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLValueEnumConverter<MetadataPosition>))]
        public APLValue<MetadataPosition?> MetadataPosition { get; set; }

        [JsonProperty("iconLeftGraphicSource", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> IconLeftGraphicSource { get; set; }

        [JsonProperty("iconRightGraphicSource", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> IconRightGraphicSource { get; set; }

        [JsonProperty("sliderSize", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLValueEnumConverter<SliderSize>))]
        public APLValue<SliderSize?> SliderSize { get; set; }

        [JsonProperty("sliderType", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLValueEnumConverter<SliderType>))]
        public APLValue<SliderType?> SliderType { get; set; }

        [JsonProperty("sliderMoveMillisecond", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> SliderMoveMillisecond { get; set; }
    }
}
