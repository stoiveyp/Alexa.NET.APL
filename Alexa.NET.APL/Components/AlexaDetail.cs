using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class AlexaDetail:ResponsiveTemplate
    {
        public override string Type => nameof(AlexaDetail);

        [JsonProperty("bodyText",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> BodyText { get; set; }

        [JsonProperty("button1AccessibilityLabel",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Button1AccessibilityLabel { get; set; }

        [JsonProperty("button1PrimaryAction", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> Button1PrimaryAction { get; set; }

        [JsonProperty("button1Style",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Button1Style { get; set; }

        [JsonProperty("button1Text",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Button1Text { get; set; }

        [JsonProperty("button1Theme",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Button1Theme { get; set; }

        [JsonProperty("button2PrimaryAction", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> Button2PrimaryAction { get; set; }

        [JsonProperty("button2Style", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Button2Style { get; set; }

        [JsonProperty("button2Text", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Button2Text { get; set; }

        [JsonProperty("button2Theme", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Button2Theme { get; set; }

        [JsonProperty("detailImageAlignment",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> DetailImageAlignment { get; set; }

        [JsonProperty("detailType",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> DetailType { get; set; }

        [JsonProperty("emptyRatingGraphic",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> EmptyRatingGraphic { get; set; }

        [JsonProperty("fullRatingGraphic", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> FullRatingGraphic { get; set; }

        [JsonProperty("halfRatingGraphic", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> HalfRatingGraphic { get; set; }

        [JsonProperty("ratingGraphicType", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(APLValueEnumConverter<RatingGraphicType>))]
        public APLValue<RatingGraphicType?> RatingGraphicType { get; set; }

        [JsonProperty("ratingNumber", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<double?> RatingNumber { get; set; }

        [JsonProperty("ratingSlotMode", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(APLValueEnumConverter<RatingSlotMode>))]
        public APLValue<RatingSlotMode?> RatingSlotMode { get; set; }

        [JsonProperty("ratingSlotPadding", NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue RatingSlotPadding { get; set; }

        [JsonProperty("ratingText", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> RatingText { get; set; }

        [JsonProperty("singleRatingGraphicWidth", NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue SingleRatingGraphicWidth { get; set; }

        [JsonProperty("singleRatingGraphic", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> SingleRatingGraphic { get; set; }

        [JsonProperty("imageAlignment", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLValueEnumConverter<AlexaImageAlignment>))]
        public APLValue<AlexaImageAlignment?> ImageAlignment { get; set; }

        [JsonProperty("imageAspectRatio", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLValueEnumConverter<AlexaImageAspectRatio>))]
        public APLValue<AlexaImageAspectRatio?> ImageAspectRatio { get; set; }

        [JsonProperty("imageBlurredBackground", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> ImageBlurredBackground { get; set; }

        [JsonProperty("imageHeight", NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue ImageHeight { get; set; }

        [JsonProperty("imageWidth", NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue ImageWidth { get; set; }

        [JsonProperty("imageRoundedCorner", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> ImageRoundedCorner { get; set; }

        [JsonProperty("imageScale", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLValueEnumConverter<Scale>))]
        public APLValue<Scale> Scale { get; set; }

        [JsonProperty("imageSource", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ImageSource { get; set; }

        [JsonProperty("imageCaption",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ImageCaption { get; set; }

        [JsonProperty("ingredientsHideDivider", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> IngredientsHideDivider { get; set; }

        [JsonProperty("ingredientsText",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> IngredientsText { get; set; }

        [JsonProperty("locationText",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> LocationText { get; set; }

        [JsonProperty("primaryText",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> PrimaryText { get; set; }

        [JsonProperty("quaternaryText",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> QuaternaryText { get; set; }

        [JsonProperty("scrollViewId",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ScrollViewId { get; set; }

        [JsonProperty("secondaryText",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> SecondaryText { get; set; }

        [JsonProperty("tertiaryText",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> TertiaryText { get; set; }

        [JsonProperty("ingredientListItems",NullValueHandling = NullValueHandling.Ignore),
        JsonConverter(typeof(GenericSingleOrListConverter<IngredientListItem>))]
        public APLValue<IList<IngredientListItem>> IngredientListItems { get; set; }



    }
}
