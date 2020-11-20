using System.Collections.Generic;
using Alexa.NET.APL;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Alexa.NET.Response.APL
{
    public class Resource:ResourceBase
    {
        public Resource()
        {

        }

        public Resource(string when = null)
        {
            When = when;
        }

        [JsonProperty("colors", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Colors { get; set; }

        [JsonProperty("dimensions", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, APLDimensionValue> Dimensions { get; set; }

        [JsonProperty("gradients",NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, APLValue<APLGradient>> Gradients { get; set; }

        [JsonProperty("easings",NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string,string> Easings { get; set; }

        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Resource> Resources { get; set; }

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
                Dimensions = new Dictionary<string, APLDimensionValue>();
            }
            Dimensions.Add(key, expression);
        }

        public void AddGradient(string key, APLValue<APLGradient> gradient)
        {
            if (Gradients == null)
            {
                Gradients = new Dictionary<string, APLValue<APLGradient>>();
            }
            Gradients.Add(key, gradient);
        }

        public void AddEasing(string key, string expression)
        {
            if (Easings == null)
            {
                Easings = new Dictionary<string, string>();
            }
            Easings.Add(key, expression);
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