using System.Collections.Generic;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Gestures
{
    public class Tap : APLGesture
    {
        public override string Type => nameof(Tap);

        [JsonProperty("onTap", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> OnTap { get; set; }
    }
}