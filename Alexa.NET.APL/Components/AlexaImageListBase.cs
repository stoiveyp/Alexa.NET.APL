using System.Collections.Generic;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public abstract class AlexaImageListBase : ResponsiveTemplate
    {
        [JsonProperty("imageAlignment", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(APLValueEnumConverter<AlexaImageAlignment>))]
        public APLValue<AlexaImageAlignment?> ImageAlignment { get; set; }

        [JsonProperty("imageAspectRatio", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(APLValueEnumConverter<AlexaImageAspectRatio>))]
        public APLValue<AlexaImageAspectRatio?> ImageAspectRatio { get; set; }

        [JsonProperty("imageBlurredBackground", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> ImageBlurredBackground { get; set; }

        [JsonProperty("imageHideScrim", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> ImageHideScrim { get; set; }

        [JsonProperty("imageMetadataPrimacy", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> ImageMetadataPrimacy { get; set; }

        [JsonProperty("imageRoundedCorner", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> ImageRoundedCorner { get; set; }

        [JsonProperty("imageScale", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(APLValueEnumConverter<Scale>))]
        public APLValue<Scale?> ImageScale { get; set; }


        [JsonProperty("primaryAction", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> PrimaryAction { get; set; }

        [JsonProperty("headerAttributionOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<double?> HeaderAttributionOpacity { get; set; }

        [JsonProperty("listId", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ListId { get; set; }

        [JsonProperty("speechItems", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> SpeechItems { get; set; }
    }
}