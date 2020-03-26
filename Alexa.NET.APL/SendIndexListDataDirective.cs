using System.Collections.Generic;
using System.Linq;
using Alexa.NET.Response.Converters;
using Newtonsoft.Json;

namespace Alexa.NET.Response
{
    public class SendIndexListDataDirective:IDirective
    {
        public const string DirectiveType = "Alexa.Presentation.APL.SendIndexListData";

        private static readonly object directiveadd = new object();

        public static void AddSupport()
        {
            lock (directiveadd)
            {
                if (!DirectiveConverter.TypeFactories.ContainsKey(DirectiveType))
                {
                    DirectiveConverter.TypeFactories.Add(DirectiveType, () => new SendIndexListDataDirective());
                }
            }
        }

        [JsonProperty("type")]
        public string Type => DirectiveType;

        [JsonProperty("token",NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        [JsonProperty("correlationToken",NullValueHandling = NullValueHandling.Ignore)]
        public string CorrelationToken { get; set; }

        [JsonProperty("listId",NullValueHandling = NullValueHandling.Ignore)]
        public string ListId { get; set; }

        [JsonProperty("listVersion",NullValueHandling = NullValueHandling.Ignore)]
        public int? ListVersion { get; set; }

        [JsonProperty("startIndex",NullValueHandling = NullValueHandling.Ignore)]
        public int? StartIndex { get; set; }

        [JsonProperty("minimumInclusiveIndex",NullValueHandling = NullValueHandling.Ignore)]
        public int? MinimumInclusiveIndex { get; set; }

        [JsonProperty("maximumExclusiveIndex",NullValueHandling = NullValueHandling.Ignore)]
        public int? MaximumExclusiveIndex { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public IList<object> Items { get; set; } = new List<object>();

        public bool ShouldSerializeItems()
        {
            return Items?.Any() ?? false;
        }
    }
}
