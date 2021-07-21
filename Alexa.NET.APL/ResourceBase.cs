using System.Collections.Generic;
using Alexa.NET.APL;
using Newtonsoft.Json;

namespace Alexa.NET.Response.APL
{
    public abstract class ResourceBase
    {
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("when", NullValueHandling = NullValueHandling.Ignore)]
        public string When { get; set; }

        [JsonProperty("strings", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Strings { get; set; }

        [JsonProperty("numbers", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, APLValue<double?>> Numbers { get; set; }

        [JsonProperty("booleans", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Booleans { get; set; }

        [JsonProperty("arrays", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Arrays { get; set; }

        [JsonProperty("maps", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Maps { get; set; }

        public void AddString(string key, string expression)
        {
            Strings ??= new Dictionary<string, string>();
            Strings.Add(key, expression);
        }

        public void AddNumber(string key, APLValue<double?> resource)
        {
            Numbers ??= new Dictionary<string, APLValue<double?>>();
            Numbers.Add(key, resource);
        }

        public void AddBoolean(string key, string expression)
        {
            Booleans ??= new Dictionary<string, string>();
            Booleans.Add(key, expression);
        }

        public void AddArray(string key, string expression)
        {
            Arrays ??= new Dictionary<string, string>();
            Arrays.Add(key, expression);
        }

        public void AddMaps(string key, string expression)
        {
            Maps ??= new Dictionary<string, string>();
            Maps.Add(key, expression);
        }
    }
}