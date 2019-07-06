using Newtonsoft.Json;

namespace Alexa.NET.APL.Commands
{
    public class ClearFocus : APLCommand
    {
        [JsonProperty("type")]
        public override string Type => nameof(ClearFocus);

    }
}