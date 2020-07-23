using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL
{
    [JsonConverter(typeof(APLCommandConverter))]
    public abstract class APLCommand
    {
        [JsonProperty("type")]
        public abstract string Type { get; }

        [JsonProperty("when",NullValueHandling = NullValueHandling.Ignore)]
        public string When { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("delay", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> DelayMilliseconds { get; set; }

        [JsonProperty("screenLock",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> ScreenLock { get; set; }

        [JsonProperty("sequencer",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Sequencer { get; set; }
    }
}
