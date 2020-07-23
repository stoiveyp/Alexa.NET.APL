using System.Collections.Generic;
using Alexa.NET.APL.JsonConverter;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Gestures
{
    public class SwipeAway : APLGesture
    {
        public override string Type => nameof(SwipeAway);

        [JsonProperty("onSwipeMove", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> OnSwipeMove { get; set; }

        [JsonProperty("onSwipeDone", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> OnSwipeDone { get; set; }

        [JsonProperty("item",NullValueHandling = NullValueHandling.Ignore),
        JsonConverter(typeof(APLComponentListConverter))]
        public APLValue<IList<APLComponent>> Item { get; set; }

        [JsonProperty("action",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<SwipeAction?> Action { get; set; }

        [JsonProperty("direction")]
        public APLValue<SwipeDirection> Direction { get; set; }
    }
}