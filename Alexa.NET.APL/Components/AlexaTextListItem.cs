using System;
using System.Text;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class AlexaTextListItem: AlexaPaginatedListItem
    {
        [JsonProperty("type")] public override string Type => nameof(AlexaTextListItem);

        [JsonProperty("hideDivider",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> HideDivider { get; set; }

        [JsonProperty("secondaryTextPosition",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> SecondaryTextPosition { get; set; }

        [JsonProperty("tertiaryTextPosition",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> TertiaryTextPosition { get; set; }
    }
}
