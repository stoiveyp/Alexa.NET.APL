using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.APL.Extensions.SmartMotion
{
    public class SetWakeWordResponseCommand : APLCommand
    {
        private string _extensionName;

        public static SetWakeWordResponseCommand For(SmartMotionExtension extension)
        {
            return new SetWakeWordResponseCommand(extension.Name);
        }

        public SetWakeWordResponseCommand(string extensionName)
        {
            _extensionName = extensionName;
        }

        public override string Type => $"{_extensionName}:SetWakeWordResponse";

        [JsonProperty("wakeWordResponse",NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public WakeWordResponse? WakeWordResponse { get; set; }
    }
}