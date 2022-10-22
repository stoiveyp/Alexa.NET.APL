using Newtonsoft.Json;

namespace Alexa.NET.APL.Commands
{
    public class Reinflate : APLCommand
    {
        public override string Type => nameof(Reinflate);

        [JsonProperty("preservedSequencers",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string[]> PreservedSequencers { get; set; }
    }
}