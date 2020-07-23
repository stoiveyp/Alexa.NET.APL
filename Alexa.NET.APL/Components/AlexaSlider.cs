using System.Collections.Generic;
using Alexa.NET.APL.JsonConverter;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class AlexaSlider:TouchComponent
    {
        public override string Type => nameof(AlexaSlider);

        [JsonProperty("bufferValue", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> BufferValue { get; set; }

        [JsonProperty("isLoading", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> IsLoading { get; set; }

        [JsonProperty("progressValue", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> ProgressValue { get; set; }

        [JsonProperty("theme", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Theme { get; set; }

        [JsonProperty("totalValue", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> TotalValue { get; set; }

        [JsonProperty("sliderId")]
        public APLValue<string> SliderId { get; set; }

        [JsonProperty("thumbDisplayAllStates",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> ThumbDisplayAllStates { get; set; }

        [JsonProperty("thumbColor",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ThumbColor { get; set; }

        [JsonProperty("sliderSize",NullValueHandling = NullValueHandling.Ignore),
        JsonConverter(typeof(APLValueEnumConverter<SliderSize>))]
        public APLValue<SliderSize?> SliderSize { get; set; }

        [JsonProperty("sliderType",NullValueHandling = NullValueHandling.Ignore),
        JsonConverter(typeof(APLValueEnumConverter<SliderType>))]
        public APLValue<SliderType?> SliderType { get; set; }

        [JsonProperty("sliderMoveMillisecond",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> SliderMoveMillisecond { get; set; }

        [JsonProperty("progressFillColor",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ProgressFillColor { get; set; }

        [JsonProperty("positionPropertyName",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> PositionPropertyName { get; set; }

        [JsonProperty("onBlurCommand", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> OnBlurCommand { get; set; }

        [JsonProperty("onUpCommand", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> OnUpCommand { get; set; }

        [JsonProperty("onDownCommand", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> OnDownCommand { get; set; }

        [JsonProperty("onFocusCommand", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> OnFocusCommand { get; set; }

        [JsonProperty("onMoveCommand", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> OnMoveCommand { get; set; }

        [JsonProperty("handleKeyDownCommand", NullValueHandling = NullValueHandling.Ignore),
        JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> HandleKeyDownCommand { get; set; }

        [JsonProperty("iconLeftGraphicSource",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> IconLeftGraphicSource { get; set; }

        [JsonProperty("iconRightGraphicSource",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> IconRightGraphicSource { get; set; }

        [JsonProperty("metadataDisplayed",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool> MetadataDisplayed { get; set; }

        [JsonProperty("metadataPosition",NullValueHandling = NullValueHandling.Ignore),
        JsonConverter(typeof(APLValueEnumConverter<MetadataPosition>))]
        public APLValue<MetadataPosition?> MetadataPosition { get; set; }

    }
}
