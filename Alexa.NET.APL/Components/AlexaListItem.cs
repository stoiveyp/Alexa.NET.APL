using System.Collections.Generic;
using Alexa.NET.APL.JsonConverter;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public abstract class AlexaListItem : APLComponent
    {
        [JsonProperty("hideOrdinal", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> HideOrdinal { get; set; }

        [JsonProperty("primaryAction", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> PrimaryAction { get; set; }

        [JsonProperty("primaryText", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> PrimaryText { get; set; }

        [JsonProperty("theme", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Theme { get; set; }
    }
}