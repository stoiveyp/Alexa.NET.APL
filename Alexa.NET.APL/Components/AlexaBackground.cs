using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.JsonConverter;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class AlexaBackground : APLComponent
    {
        [JsonProperty("type")]
        public override string Type => nameof(AlexaBackground);

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

    }
}
