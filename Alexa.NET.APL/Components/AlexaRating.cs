using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.JsonConverter;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.APL.Components
{
    public class AlexaRating:APLComponent
    {
        public override string Type => nameof(AlexaRating);

        [JsonProperty("emptyRatingGraphic",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> EmptyRatingGraphic { get; set; }

        [JsonProperty("fullRatingGraphic",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> FullRatingGraphic { get; set; }

        [JsonProperty("halfRatingGraphic",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> HalfRatingGraphic { get; set; }

        [JsonProperty("ratingGraphicType",NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(APLValueEnumConverter<RatingGraphicType>))]
        public APLValue<RatingGraphicType?> RatingGraphicType { get; set; }

        [JsonProperty("ratingNumber",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<double?> RatingNumber { get; set; }

        [JsonProperty("ratingSlotMode",NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(APLValueEnumConverter<RatingSlotMode>))]
        public APLValue<RatingSlotMode?> RatingSlotMode { get; set; }

        [JsonProperty("ratingSlotPadding",NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue RatingSlotPadding { get; set; }

        [JsonProperty("ratingText",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> RatingText { get; set; }

        [JsonProperty("singleRatingGraphicWidth",NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue SingleRatingGraphicWidth { get; set; }

        [JsonProperty("singleRatingGraphic",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> SingleRatingGraphic { get; set; }

        [JsonProperty("ratingTextOpacity",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<double?> RatingTextOpacity { get; set; }
    }
}
