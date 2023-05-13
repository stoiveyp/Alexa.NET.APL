using Newtonsoft.Json;

namespace Alexa.NET.Request
{
    public class Usage
    {
        [JsonProperty("instanceId",NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }
}