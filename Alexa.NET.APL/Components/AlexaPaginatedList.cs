using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class AlexaPaginatedList:ResponsiveTemplate
    {
        public override string Type => nameof(AlexaPaginatedList);

        [JsonProperty("primaryAction", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> PrimaryAction { get; set; }

        [JsonProperty("listItems", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<IList<AlexaPaginatedListItem>> ListItems { get; set; }

        [JsonProperty("headerAttributionOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<double?> HeaderAttributionOpacity { get; set; }

        [JsonProperty("listId", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ListId { get; set; }

        [JsonProperty("speechItems", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> SpeechItems { get; set; }
    }
}
