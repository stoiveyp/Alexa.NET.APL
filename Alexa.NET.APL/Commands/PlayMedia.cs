using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.Components;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Commands
{
    public class PlayMedia:APLCommand
    {
        public override string Type => "PlayMedia";

        [JsonProperty("audioTrack", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> AudioTrack { get; set; } = "foreground";

        [JsonProperty("componentId", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ComponentId { get; set; }

        [JsonProperty("source")]
        public APLValue<IList<VideoSource>> Source { get; set; }
    }
}
