using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Alexa.NET.Response.APL
{
    public class Resource
    {
        public Resource()
        {

        }

        public Resource(string when = null)
        {
            When = when;
        }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("when", NullValueHandling = NullValueHandling.Ignore)]
        public string When { get; set; }

        [JsonProperty("boolean",NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Booleans { get; set; }
        [JsonProperty("colors", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Colors { get; set; }
        [JsonProperty("dimensions", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Dimensions { get; set; }
        [JsonProperty("strings", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Strings { get; set; }
        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Resource> Resources { get; set; }

        public void AddBoolean(string key, string expression)
        {
            if (Booleans == null)
            {
                Booleans = new Dictionary<string, string>();
            }
            Booleans.Add(key,expression);
        }

        public void AddColor(string key, string expression)
        {
            if (Colors == null)
            {
                Colors = new Dictionary<string, string>();
            }
            Colors.Add(key, expression);
        }

        public void AddDimension(string key, string expression)
        {
            if (Dimensions == null)
            {
                Dimensions = new Dictionary<string, string>();
            }
            Dimensions.Add(key, expression);
        }

        public void AddString(string key, string expression)
        {
            if (Strings == null)
            {
                Strings = new Dictionary<string, string>();
            }
            Strings.Add(key, expression);
        }

        public void AddResource(string key, Resource resource)
        {
            if (Resources == null)
            {
                Resources = new List<Resource>();
            }
            Resources.Add(resource);
        }
    }
}