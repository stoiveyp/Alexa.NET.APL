using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class AlexaImageListItem : AlexaPaginatedListItem
    {
        [JsonProperty("type")] public override string Type => nameof(AlexaImageListItem);

        [JsonProperty("defaultImageSource",NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultImageSource { get; set; }

        [JsonProperty("imageAlignment", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLValueEnumConverter<AlexaImageAlignment>))]
        public APLValue<AlexaImageAlignment?> ImageAlignment { get; set; }

        [JsonProperty("imageAspectRatio", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLValueEnumConverter<AlexaImageAspectRatio>))]
        public APLValue<AlexaImageAspectRatio?> ImageAspectRatio { get; set; }

        [JsonProperty("imageBlurredBackground", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> ImageBlurredBackground { get; set; }

        [JsonProperty("imageHideScim",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> ImageHideScrim { get; set; }

        [JsonProperty("imageMetadataPrimary",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> ImageMetadataPrimary { get; set; }

        [JsonProperty("imageProgressBarPercentage",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> ImageProgressBarPercentage { get; set; }

        [JsonProperty("imageRoundedCorner",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> ImageRoundedCorner { get; set; }

        [JsonProperty("imageScale",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<Scale?> ImageScale { get; set; }

        [JsonProperty("providerText",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ProviderText { get; set; }

        [JsonProperty("hasPlayIcon",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> HasPlayIcon { get; set; }

        [JsonProperty("imageSource", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ImageSource { get; set; }

        [JsonProperty("imageShadow", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> ImageShadow { get; set; }

        [JsonProperty("contentDirection",NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(APLValueEnumConverter<ContentDirection>))]
        public APLValue<ContentDirection?> ContentDirection { get; set; }

        [JsonProperty("imageAltText", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ImageAltText { get; set; }
    }
}