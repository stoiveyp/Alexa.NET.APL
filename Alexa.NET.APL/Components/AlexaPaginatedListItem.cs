using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public abstract class AlexaPaginatedListItem:AlexaListItem
    {
        [JsonProperty("secondaryText", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> SecondaryText { get; set; }

        [JsonProperty("tertiaryText", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> TertiaryText { get; set; }
    }
}