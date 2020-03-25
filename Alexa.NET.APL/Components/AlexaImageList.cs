using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class AlexaImageList: ResponsiveTemplate
    {
        public override string Type => nameof(AlexaImageList);

        [JsonProperty("defaultImageSource",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> DefaultImageSource { get; set; }

        [JsonProperty("imageAlignment",NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(APLValueEnumConverter<AlexaImageAlignment>))]
        public APLValue<AlexaImageAlignment?> ImageAlignment { get; set; }

        [JsonProperty("imageAspectRatio",NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(APLValueEnumConverter<AlexaImageAspectRatio>))]
        public APLValue<AlexaImageAspectRatio?> ImageAspectRatio { get; set; }

        [JsonProperty("imageBlurredBackground",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> ImageBlurredBackground { get; set; }

        [JsonProperty("imageHideScrim",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> ImageHideScrim { get; set; }

        [JsonProperty("imageMetadataPrimacy",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> ImageMetadataPrimacy { get; set; }

        [JsonProperty("imageRoundedCorner",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> ImageRoundedCorner { get; set; }

        [JsonProperty("imageScale",NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(APLValueEnumConverter<Scale>))]
        public APLValue<Scale?> ImageScale { get; set; }

        [JsonProperty("listItems",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<IList<AlexaImageListItem>> ListItems { get; set; }

        [JsonProperty("primaryAction", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> PrimaryAction { get; set; }

        [JsonProperty("videoAudioTrack", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> VideoAudioTrack { get; set; }

        [JsonProperty("videoAutoPlay", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> VideoAutoPlay { get; set; }
    }
}
