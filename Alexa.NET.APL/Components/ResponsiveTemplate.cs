using System.Collections.Generic;
using Alexa.NET.APL.JsonConverter;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public abstract class ResponsiveTemplate : APLComponent
    {
        [JsonProperty("backgroundAlign", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> BackgroundAlign { get; set; }

        [JsonProperty("backgroundBlur", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> BackgroundBlur { get; set; }

        [JsonProperty("backgroundColor", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> BackgroundColor { get; set; }

        [JsonProperty("backgroundColorOverlay",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> BackgroundColorOverlay { get; set; }

        [JsonProperty("backgroundOverlayGradient",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> BackgroundOverlayGradient { get; set; }

        [JsonProperty("backgroundImageSource", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> BackgroundImageSource { get; set; }

        [JsonProperty("backgroundScale",NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(APLValueEnumConverter<Scale>))]
        public APLValue<Scale?> BackgroundScale { get; set; }

        [JsonProperty("backgroundVideoSource", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<VideoSource> BackgroundVideoSource { get; set; }

        [JsonProperty("backgroundVideoAudioTrack", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> BackgroundVideoAudioTrack { get; set; }

        [JsonProperty("backgroundVideoAutoPlay", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> BackgroundVideoAutoPlay { get; set; }

        [JsonProperty("headerDivider", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> HeaderDivider { get; set; }

        [JsonProperty("headerTitle", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> HeaderTitle { get; set; }

        [JsonProperty("headerSubtitle", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> HeaderSubtitle { get; set; }

        [JsonProperty("headerAttributionText", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> HeaderAttributionText { get; set; }

        [JsonProperty("headerAttributionImage", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> HeaderAttributionImage { get; set; }

        [JsonProperty("headerAttributionPrimacy", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> HeaderAttributionPrimacy { get; set; }

        [JsonProperty("headerBackButton", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> HeaderBackButton { get; set; }

        [JsonProperty("headerBackButtonAccessibilityLabel", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> HeaderBackButtonAccessibilityLabel { get; set; }

        [JsonProperty("headerBackButtonCommand", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> HeaderBackButtonCommand { get; set; }

        [JsonProperty("headerBackgroundColor", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> HeaderBackgroundColor { get; set; }

        [JsonProperty("theme", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Theme { get; set; }

        [JsonProperty("hintText", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> HintText { get; set; }
    }
}