using System.Collections.Generic;
using Alexa.NET.APL.Commands;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class TouchWrapper : APLComponent
    {
        public TouchWrapper()
        {

        }

        public TouchWrapper(APLComponent item)
        {
            Item = new List<APLComponent> { item };
        }

        public TouchWrapper(params APLComponent[] item) : this((IEnumerable<APLComponent>)item)
        {

        }

        public TouchWrapper(IEnumerable<APLComponent> item)
        {
            Item = new List<APLComponent>(item);
        }

        public override string Type => nameof(TouchWrapper);

        [JsonProperty("disabled", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> Boolean { get; set; }

        [JsonProperty("item", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<IList<APLComponent>> Item { get; set; }

        [JsonProperty("onPress", NullValueHandling = NullValueHandling.Ignore)]
        public SendEvent OnPress { get; set; }
    }
}
