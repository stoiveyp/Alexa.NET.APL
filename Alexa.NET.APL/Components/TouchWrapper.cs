using System.Collections.Generic;
using Alexa.NET.APL.Commands;
using Alexa.NET.APL.JsonConverter;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class TouchWrapper : TouchComponent
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

        [JsonProperty("type")]
        public override string Type => nameof(TouchWrapper);


        [JsonProperty("item", NullValueHandling = NullValueHandling.Ignore),
        JsonConverter(typeof(APLComponentListConverter))]
        public APLValue<IList<APLComponent>> Item { get; set; }

        [JsonProperty("onPress", NullValueHandling = NullValueHandling.Ignore),
        JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> OnPress { get; set; }
    }
}
