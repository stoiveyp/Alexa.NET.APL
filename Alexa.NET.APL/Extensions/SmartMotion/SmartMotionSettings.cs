using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.APL.Extensions.SmartMotion
{
    public class SmartMotionSettings
    {
        [JsonProperty("deviceStateName",NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceStateName { get; set; }

        [JsonProperty("wakeWordResponse",NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(StringEnumConverter))]
        public WakeWordResponse? WakeWordResponse { get; set; }
    }
}
