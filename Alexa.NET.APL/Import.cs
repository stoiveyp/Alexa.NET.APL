using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Alexa.NET.Response.APL
{
    public class Import
    {
        public Import() { }

        public Import(string name, string version)
        {
            Name = name;
            Version = version;
        }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        public static Import AlexaStyles => new Import("alexa-styles","1.0.0");
        public static Import AlexaViewportProfiles => new Import("alexa-viewport-profiles", "1.0.0");
        public static Import AlexaLayouts => new Import("alexa-layouts","1.0.0");
    }
}