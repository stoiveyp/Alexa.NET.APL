using Newtonsoft.Json;

namespace Alexa.NET.APL.Extensions.SmartMotion
{
    public class PlayNamedChoreoCommand : APLCommand
    {
        private string _extensionName;

        public static PlayNamedChoreoCommand For(SmartMotionExtension extension, string choreoName = null)
        {
            return new PlayNamedChoreoCommand(extension.Name, choreoName);
        }

        public PlayNamedChoreoCommand(string extensionName, string choreoName = null)
        {
            _extensionName = extensionName;
            Name = choreoName;
        }

        [JsonProperty("name",NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        public override string Type => $"{_extensionName}:PlayNamedChoreo";
    }
}