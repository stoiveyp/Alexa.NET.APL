using Newtonsoft.Json;

namespace Alexa.NET.Response.APL
{
    public class Export
    {
        public Export() { }

        public Export(string name)
        {
            Name = name;
        }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description",NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        public static implicit operator Export(string exportName)
        {
            return new Export(exportName);
        }
    }
}