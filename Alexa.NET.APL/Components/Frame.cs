using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.JsonConverter;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class Frame:APLComponent
    {
        public Frame() { }

        public Frame(APLComponent item)
        {
            Item = new List<APLComponent> {item};
        }

        public Frame(params APLComponent[] item):this((IEnumerable<APLComponent>)item)
        {
            
        }

        public Frame(IEnumerable<APLComponent> item)
        {
            Item = new List<APLComponent>(item);
        }


        public const string ComponentType = "Frame";

        public override string Type => ComponentType;

        [JsonProperty("backgroundColor",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> BackgroundColor { get; set; }

        [JsonProperty("borderBottomLeftRadius",NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue BorderBottomLeftRadius { get; set; }

        [JsonProperty("borderBottomRightRadius",NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue BorderBottomRightRadius { get; set; }

        [JsonProperty("borderColor",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> BorderColor { get; set; }

        [JsonProperty("borderRadius",NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue BorderRadius { get; set; }

        [JsonProperty("borderTopLeftRadius",NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue BorderTopLeftRadius { get; set; }

        [JsonProperty("borderTopRightRadius",NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue BorderTopRightRadius { get; set; }

        [JsonProperty("borderWidth",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> BorderWidth { get; set; }

        [JsonProperty("item",NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLComponentListConverter))]
        public APLValue<IList<APLComponent>> Item { get; set; }

        [JsonProperty("borderStrokeWidth",NullValueHandling = NullValueHandling.Ignore)]
        public APLAbsoluteDimensionValue BorderStrokeWidth { get; set; }
    }
}
