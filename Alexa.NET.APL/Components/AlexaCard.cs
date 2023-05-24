using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class AlexaCard:ResponsiveTemplate
    {
        public override string Type => nameof(AlexaCard);

        [JsonProperty("cardBackgroundColor",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> CardBackgroundColor { get; set; }

        [JsonProperty("cardId",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> CardId { get; set; }

        [JsonProperty("cardRoundedCorner",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> CardRoundedCorner { get; set; }

        [JsonProperty("cardShadow",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> CardShadow { get; set; }

        [JsonProperty("emptyRatingGraphic", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> EmptyRatingGraphic { get; set; }

        [JsonProperty("fullRatingGraphic", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> FullRatingGraphic { get; set; }

        [JsonProperty("halfRatingGraphic", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> HalfRatingGraphic { get; set; }

        [JsonProperty("headerText",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> HeaderText { get; set; }

        [JsonProperty("imageAltText", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ImageAltText { get; set; }

        [JsonProperty("imageCaption", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> ImageCaption { get; set; }

        [JsonProperty("imageHideScrim", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> ImageHideScrim { get; set; }

        [JsonProperty("imageProgressBarPercentage", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> ImageProgressBarPercentage { get; set; }

        [JsonProperty("imageShowProgressBar", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> ImageShowProgressBar { get; set; }

        [JsonProperty("imageSource",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ImageSource { get; set; }

        [JsonProperty("primaryAction", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> PrimaryAction { get; set; }

        [JsonProperty("primaryText",NullValueHandling = NullValueHandling.Ignore)]
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

        [JsonProperty("secondaryIconName",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> SecondaryIconName { get; set; }

        [JsonProperty("secondaryIconSource",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> SecondaryIconSource { get; set; }

        [JsonProperty("secondaryText",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> SecondaryText { get; set; }

        [JsonProperty("singleRatingGraphicWidth", NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue SingleRatingGraphicWidth { get; set; }

        [JsonProperty("singleRatingGraphic", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> SingleRatingGraphic { get; set; }

        [JsonProperty("tertiaryIconName",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> TertiaryIconName { get; set; }

        [JsonProperty("tertiaryIconSource",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> TertiaryIconSource { get; set; }

        [JsonProperty("tertiaryText",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> TertiaryText { get; set; }
    }
}
