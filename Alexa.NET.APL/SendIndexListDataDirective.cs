using Alexa.NET.Response.Converters;
using Newtonsoft.Json;

namespace Alexa.NET.Response
{
    public class SendIndexListDataDirective:ListDataDirective
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
        public override string Type => DirectiveType;

        [JsonProperty("listVersion",NullValueHandling = NullValueHandling.Ignore)]
        public int? ListVersion { get; set; }

        [JsonProperty("startIndex",NullValueHandling = NullValueHandling.Ignore)]
        public int? StartIndex { get; set; }

        [JsonProperty("minimumInclusiveIndex",NullValueHandling = NullValueHandling.Ignore)]
        public int? MinimumInclusiveIndex { get; set; }

        [JsonProperty("maximumExclusiveIndex",NullValueHandling = NullValueHandling.Ignore)]
        public int? MaximumExclusiveIndex { get; set; }

    }
}
