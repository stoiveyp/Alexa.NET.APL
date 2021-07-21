using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.JsonConverter;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class AlexaTextList:APLComponent
    {
        [JsonProperty("type")] public override string Type => nameof(AlexaTextList);


        [JsonProperty("backgroundAlign", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> BackgroundAlign { get; set; }

        [JsonProperty("backgroundBlur", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> BackgroundBlur { get; set; }

        [JsonProperty("backgroundColor", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> BackgroundColor { get; set; }

        [JsonProperty("backgroundImageSource", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> BackgroundImageSource { get; set; }

        [JsonProperty("backgroundVideoSource", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<VideoSource> BackgroundVideoSource { get; set; }

        [JsonProperty("backgroundScale", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLValueEnumConverter<Scale>))]
        public APLValue<Scale> BackgroundScale { get; set; }

        [JsonProperty("colorOverlay", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> ColorOverlay { get; set; }


        [JsonProperty("overlayGradient", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> OverlayGradient { get; set; }


        [JsonProperty("videoAudioTrack", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> VideoAudioTrack { get; set; } = "foreground";


        [JsonProperty("videoAutoPlay", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> VideoAutoPlay { get; set; }

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

        [JsonProperty("headerDivider", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> HeaderDivider { get; set; }

        [JsonProperty("hideDivider", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> HideDivider { get; set; }

        [JsonProperty("hideOrdinal", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> HideOrdinal { get; set; }

        [JsonProperty("primaryAction", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> PrimaryAction { get; set; }

        [JsonProperty("listItems",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<List<AlexaTextListItem>> ListItems { get; set; }

        [JsonProperty("theme", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Theme { get; set; }

        [JsonProperty("onSwipeDone", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> OnSwipeDone { get; set; }

        [JsonProperty("onSwipeMove", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> OnSwipeMove { get; set; }

        [JsonProperty("swipeActionIconBackground", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> SwipeActionIconBackground { get; set; }

        [JsonProperty("swipeActionIconForeground", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> SwipeActionIconForeground { get; set; }

        [JsonProperty("optionsButton1Command", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> OptionsButton1Command { get; set; }

        [JsonProperty("optionsButton1Text", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> OptionsButton1Text { get; set; }

        [JsonProperty("optionsButton2Command", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> OptionsButton2Command { get; set; }

        [JsonProperty("optionsButton2Text", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> OptionsButton2Text { get; set; }

        [JsonProperty("swipeDirection", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> SwipeDirection { get; set; }

        [JsonProperty("swipeActionIcon", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> SwipeActionIcon { get; set; }

        [JsonProperty("swipeActionIconType", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> SwipeActionIconType { get; set; }

        [JsonProperty("lang", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Lang { get; set; }
    }
}
