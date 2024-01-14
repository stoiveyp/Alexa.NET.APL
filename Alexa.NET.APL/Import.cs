using System;
using System.Collections.Generic;
using System.Linq;
using Alexa.NET.APL;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace Alexa.NET.Response.APL
{
    public class Import:IEquatable<Import>
    {
        public Import() { }

        public Import(string name, string version)
        {
            Name = name;
            Version = version;
        }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version",NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        [JsonProperty("source",NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        [JsonProperty("when", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> When { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public ImportType? Type { get; set; }

        [JsonProperty("loadAfter", NullValueHandling = NullValueHandling.Ignore)] 
        [JsonConverter(typeof(StringOrArrayConverter))]
        public IList<string> LoadAfter { get; set; } = new List<string>();

        public static Import AlexaStyles => new Import("alexa-styles","1.6.0");
        public static Import AlexaViewportProfiles => new Import("alexa-viewport-profiles", "1.6.0");
        public static Import AlexaLayouts => new Import("alexa-layouts","1.7.0");
        public static Import AlexaIcon => new Import("alexa-icon","1.0.0");

        public void Into(APLDocument document)
        {

            if (document.Imports == null)
            {
                document.Imports = new List<Import>();
            }
            else if (document.Imports.Contains(this))
            {
                return;
            }

            document.Imports.Add(this);
        }

        public bool Equals(Import other)
        {
            if (other == null)
            {
                return false;
            }

            return other.Name == Name && other.Version == Version;
        }

        public bool ShouldSerializeLoadAfter()
        {
            return LoadAfter?.Any() ?? false;
        }
    }
}