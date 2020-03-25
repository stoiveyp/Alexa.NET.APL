using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.JsonConverter;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class AlexaHeadline:ResponsiveTemplate
    {
        [JsonProperty("type")] public override string Type => nameof(AlexaHeadline);

        [JsonProperty("colorOverlay", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> ColorOverlay { get; set; }


        [JsonProperty("overlayGradient", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> OverlayGradient { get; set; }


        [JsonProperty("videoAudioTrack", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> VideoAudioTrack { get; set; }


        [JsonProperty("videoAutoPlay", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> VideoAutoPlay { get; set; }

        [JsonProperty("primaryText",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> PrimaryText { get; set; }

        [JsonProperty("secondaryText", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> SecondaryText { get; set; }

    }
}
