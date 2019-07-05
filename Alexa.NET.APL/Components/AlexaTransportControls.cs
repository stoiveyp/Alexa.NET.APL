using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class AlexaTransportControls:APLComponent
    {
        [JsonProperty("type")] public override string Type => nameof(AlexaTransportControls);

        [JsonProperty("secondaryControls",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> SecondaryControls { get; set; }

        [JsonProperty("primaryControlSize",NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue PrimaryControlSize { get; set; }

        [JsonProperty("secondaryControlSize",NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue SecondaryControlSize { get; set; }

        [JsonProperty("mediaComponentId",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> MediaComponentId { get; set; }

        [JsonProperty("autoplay",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool> Autoplay { get; set; }

        [JsonProperty("playPauseToggleButtonId",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> PlayPauseToggleButtonId { get; set; }


    }
}
