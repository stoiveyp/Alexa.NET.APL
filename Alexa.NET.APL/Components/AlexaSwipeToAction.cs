using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.JsonConverter;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class AlexaSwipeToAction:APLComponent
    {
        [JsonProperty("type")]
        public override string Type => nameof(AlexaSwipeToAction);

        [JsonProperty("actionIcon",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ActionIcon{ get; set; }

        [JsonProperty("actionIconBackground",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ActionIconBackground { get; set; }

        [JsonProperty("actionIconForeground",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ActionIconForeground { get; set; }

        [JsonProperty("actionIconType",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ActionIconType { get; set; }

        [JsonProperty("button1Command", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> Button1Command { get; set; }

        [JsonProperty("button1Text",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Button1Text { get; set; }

        [JsonProperty("button2Command", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> Button2Command { get; set; }

        [JsonProperty("button2Text", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Button2Text { get; set; }

        [JsonProperty("buttonsSpacingRight",NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue ButtonsSpacingRight { get; set; }

        [JsonProperty("buttonsSpacingTop", NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue ButtonsSpacingTop{ get; set; }

        [JsonProperty("customLayoutName",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> CustomLayoutName { get; set; }

        [JsonProperty("direction",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Direction { get; set; }

        [JsonProperty("emptyRatingGraphic", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> EmptyRatingGraphic { get; set; }

        [JsonProperty("fullRatingGraphic", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> FullRatingGraphic { get; set; }

        [JsonProperty("halfRatingGraphic", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> HalfRatingGraphic { get; set; }

        [JsonProperty("hideDivider", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> HideDivider { get; set; }

        [JsonProperty("hideOrdinal", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> HideOrdinal { get; set; }

        [JsonProperty("hideHorizontalMargin", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> HideHorizontalMargin { get; set; }

        [JsonProperty("imageAlignment", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLValueEnumConverter<AlexaImageAlignment>))]
        public APLValue<AlexaImageAlignment?> ImageAlignment { get; set; }

        [JsonProperty("imageBlurredBackground", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> ImageBlurredBackground { get; set; }

        [JsonProperty("imageScale", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLValueEnumConverter<Scale>))]
        public APLValue<Scale?> Scale { get; set; }

        [JsonProperty("imageThumbnailSource",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ImageThumbnailSource { get; set; }

        [JsonProperty("onButtonsHidden", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> OnButtonsHidden { get; set; }

        [JsonProperty("onButtonsShown", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> OnButtonsShown{ get; set; }

        [JsonProperty("onSwipeDone", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> OnSwipeDone{ get; set; }

        [JsonProperty("onSwipeMove", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> OnSwipeMove { get; set; }

        [JsonProperty("primaryAction", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> PrimaryAction { get; set; }

        [JsonProperty("primaryText", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> PrimaryText { get; set; }

        [JsonProperty("ratingGraphicType", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(APLValueEnumConverter<RatingGraphicType>))]
        public APLValue<RatingGraphicType?> RatingGraphicType { get; set; }

        [JsonProperty("ratingNumber", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<double?> RatingNumber { get; set; }

        [JsonProperty("ratingSlotMode", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(APLValueEnumConverter<RatingSlotMode>))]
        public APLValue<RatingSlotMode?> RatingSlotMode { get; set; }

        [JsonProperty("ratingText", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> RatingText { get; set; }

        [JsonProperty("secondaryText", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> SecondaryText { get; set; }

        [JsonProperty("secondaryTextPosition", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> SecondaryTextPosition { get; set; }

        [JsonProperty("singleRatingGraphicWidth", NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue SingleRatingGraphicWidth { get; set; }

        [JsonProperty("singleRatingGraphic", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> SingleRatingGraphic { get; set; }

        [JsonProperty("tertiaryText", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> TertiaryText { get; set; }

        [JsonProperty("tertiaryTextPosition", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> TertiaryTextPosition { get; set; }

        [JsonProperty("touchForward", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> TouchForward { get; set; }

        [JsonProperty("theme", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Theme { get; set; }

        [JsonProperty("lang", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Lang { get; set; }
    }
}
