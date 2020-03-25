using System;
using System.Text;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class AlexaTextListItem: AlexaListItem
    {
        [JsonProperty("type")] public override string Type => nameof(AlexaTextListItem);

        [JsonProperty("hideDivider",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> HideDivider { get; set; }
    }
}
