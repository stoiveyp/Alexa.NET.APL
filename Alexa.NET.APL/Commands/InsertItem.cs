using Newtonsoft.Json;
using System.Collections.Generic;
using Alexa.NET.APL.JsonConverter;

namespace Alexa.NET.APL.Commands
{
    public class InsertItem:APLCommand
    {
        [JsonProperty("type")]
        public override string Type => nameof(InsertItem);

        [JsonProperty("at", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> At { get; set; }

        [JsonProperty("componentId", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ComponentId { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(GenericSingleOrListConverter<object>))]
        public APLValue<IList<object>> Items { get; set; }
    }
}
