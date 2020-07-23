using System.Collections.Generic;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public abstract class AlexaSliderBase:TouchComponent
    {
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

        [JsonProperty("thumbDisplayAllStates",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> ThumbDisplayAllStates { get; set; }

        [JsonProperty("thumbColor",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ThumbColor { get; set; }

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

        [JsonProperty("metadataDisplayed",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool> MetadataDisplayed { get; set; }

    }
}