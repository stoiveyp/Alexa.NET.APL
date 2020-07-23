using System.Collections.Generic;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Gestures
{
    public class LongPress : APLGesture
    {
        public override string Type => nameof(LongPress);

        [JsonProperty("onLongPressStart", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> OnLongPressStart{ get; set; }

        [JsonProperty("onLongPressEnd", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> OnLongPressEnd { get; set; }
    }
}