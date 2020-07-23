using System;
using System.Collections.Generic;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Gestures
{
    public class DoublePress:APLGesture
    {
        public override string Type => nameof(DoublePress);

        [JsonProperty("onDoublePress", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> OnDoublePress { get; set; }

        [JsonProperty("onSinglePress", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> OnSinglePress { get; set; }
    }
}
