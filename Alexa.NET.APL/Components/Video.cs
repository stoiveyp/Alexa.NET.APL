using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.JsonConverter;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace Alexa.NET.APL.Components
{
    public class Video:APLComponent{
        public override string Type => "Video";

        [JsonProperty("audioTrack", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> AudioTrack { get; set; }

        [JsonProperty("autoplay", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool> Autoplay { get; set; }

        [JsonProperty("scale", NullValueHandling = NullValueHandling.Ignore),JsonConverter(typeof(APLValueEnumConverter<Scale>))]
        public APLValue<Scale> Scale { get; set; }

        [JsonProperty("align", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Align { get; set; }

        [JsonProperty("onEnd", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<List<APLCommand>> OnEnd { get; set; }

        [JsonProperty("source",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<List<VideoSource>> Source { get; set; }

        [JsonProperty("onPause", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<List<APLCommand>> OnPause { get; set; }

        [JsonProperty("onPlay", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<List<APLCommand>> OnPlay { get; set; }

        [JsonProperty("onTrackUpdate", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<List<APLCommand>> OnTrackUpdate { get; set; }
    }
}
