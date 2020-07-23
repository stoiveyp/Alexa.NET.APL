using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.JsonConverter;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class AlexaImage:APLComponent
    {
        [JsonProperty("type")]
        public override string Type => nameof(AlexaImage);

        [JsonProperty("imageAlignment",NullValueHandling = NullValueHandling.Ignore),
        JsonConverter(typeof(APLValueEnumConverter<AlexaImageAlignment>))]
        public APLValue<AlexaImageAlignment?> ImageAlignment { get; set; }

        [JsonProperty("imageAspectRatio",NullValueHandling = NullValueHandling.Ignore),
        JsonConverter(typeof(APLValueEnumConverter<AlexaImageAspectRatio>))]
        public APLValue<AlexaImageAspectRatio?> ImageAspectRatio { get; set; }

        [JsonProperty("imageBlurredBackground",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> ImageBlurredBackground { get; set; }

        [JsonProperty("imageHeight",NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue ImageHeight { get; set; }

        [JsonProperty("imageWidth",NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue ImageWidth { get; set; }

        [JsonProperty("imageRoundedCorner",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> ImageRoundedCorner { get; set; }

        [JsonProperty("imageScale",NullValueHandling = NullValueHandling.Ignore),
        JsonConverter(typeof(APLValueEnumConverter<Scale>))]
        public APLValue<Scale?> Scale { get; set; }

        [JsonProperty("imageSource",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ImageSource { get; set; }

    }
}
