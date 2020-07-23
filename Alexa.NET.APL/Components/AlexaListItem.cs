using System.Collections.Generic;
using Alexa.NET.APL.JsonConverter;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public abstract class AlexaListItem : APLComponent
    {
        [JsonProperty("hideOrdinal", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> HideOrdinal { get; set; }

        [JsonProperty("primaryAction", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> PrimaryAction { get; set; }

        [JsonProperty("primaryText", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> PrimaryText { get; set; }

        [JsonProperty("theme", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Theme { get; set; }

        [JsonProperty("emptyRatingGraphic", NullValueHandling = NullValueHandling.Ignore)]
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

        [JsonProperty("ratingText", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> RatingText { get; set; }

        [JsonProperty("singleRatingGraphicWidth", NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue SingleRatingGraphicWidth { get; set; }

        [JsonProperty("singleRatingGraphic", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> SingleRatingGraphic { get; set; }
    }
}