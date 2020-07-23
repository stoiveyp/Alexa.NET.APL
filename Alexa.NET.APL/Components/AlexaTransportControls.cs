using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.Commands;
using Alexa.NET.APL.JsonConverter;
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
        public APLValue<bool?> Autoplay { get; set; }

        [JsonProperty("playPauseToggleButtonId",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> PlayPauseToggleButtonId { get; set; }

        [JsonProperty("theme", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Theme { get; set; }

        [JsonProperty("primaryControlPauseAction",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<ControlMediaCommand> PrimaryControlPauseAction { get; set; }

        [JsonProperty("primaryControlPlayAction", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<ControlMediaCommand> PrimaryControlPlayAction { get; set; }

        [JsonProperty("secondaryControlsAVGLeft",NullValueHandling = NullValueHandling.Ignore),
            JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> SecondaryControlsAVGLeft { get; set; }

        [JsonProperty("secondaryControlsAVGRight", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> SecondaryControlsAVGRight { get; set; }

        [JsonProperty("secondaryControlsLeftAction", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> SecondaryControlsLeftAction { get; set; }

        [JsonProperty("secondaryControlsRightAction", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> SecondaryControlsRightAction{ get; set; }
    }
}
