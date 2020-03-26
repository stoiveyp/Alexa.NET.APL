using System.Collections.Generic;
using Alexa.NET.APL.Operation;
using Alexa.NET.Response.Converters;
using Newtonsoft.Json;

namespace Alexa.NET.Response
{
    public class UpdateIndexListDataDirective:IDirective
    {
        public const string DirectiveType = "Alexa.Presentation.APL.UpdateIndexListData";

        private static readonly object directiveadd = new object();

        public static void AddSupport()
        {
            lock (directiveadd)
            {
                if (!DirectiveConverter.TypeFactories.ContainsKey(DirectiveType))
                {
                    DirectiveConverter.TypeFactories.Add(DirectiveType, () => new UpdateIndexListDataDirective());
                }
            }
        }

        [JsonProperty("type")] public string Type => DirectiveType;

        [JsonProperty("token",NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        [JsonProperty("listId",NullValueHandling = NullValueHandling.Ignore)]
        public string ListId { get; set; }

        [JsonProperty("listVersion",NullValueHandling = NullValueHandling.Ignore)]
        public int? ListVersion { get; set; }

        [JsonProperty("operations",NullValueHandling = NullValueHandling.Ignore)]
        public IList<Operation> Operations { get; set; } = new List<Operation>();
    }
}
