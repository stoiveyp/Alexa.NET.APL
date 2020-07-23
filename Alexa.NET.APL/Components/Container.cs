using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Alexa.NET.APL.JsonConverter;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class Container:APLComponent
    {
        public Container() { }

        public Container(params APLComponent[] items) : this((IEnumerable<APLComponent>)items) { }

        public Container(IEnumerable<APLComponent> items)
        {
            Items = items.ToList();
        }

        [JsonProperty("type")]
        public override string Type => nameof(Container);
        
        [JsonProperty("alignItems",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> AlignItems { get; set; }

        [JsonProperty("data",NullValueHandling = NullValueHandling.Ignore),
        JsonConverter(typeof(GenericSingleOrListConverter<object>))]
        public APLValue<IList<object>> Data { get; set; }

        [JsonProperty("direction",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Direction { get; set; }

        [JsonProperty("firstItem",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<List<APLComponent>> FirstItem { get; set; }

        [JsonProperty("lastItem",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<List<APLComponent>> LastItem { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLComponentListConverter))]
        public APLValue<IList<APLComponent>> Items { get; set; }

        [JsonProperty("justifyContent",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> JustifyContent { get; set; }

        [JsonProperty("numbered",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> Numbered { get; set; }

        [JsonProperty("wrap",NullValueHandling = NullValueHandling.Ignore),
            JsonConverter(typeof(APLValueEnumConverter<ContainerWrap>))]
        public APLValue<ContainerWrap?> Wrap { get; set; }

    }

    public enum ContainerWrap
    {
        [EnumMember(Value="wrapReverse")]
        WrapReverse,
        [EnumMember(Value="noWrap")]
        NoWrap,
        [EnumMember(Value="wrap")]
        Wrap
    }
}
