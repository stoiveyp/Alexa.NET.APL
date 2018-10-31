using Newtonsoft.Json;

namespace Alexa.NET.APL
{
    public class AlexaDisplay
    {
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}