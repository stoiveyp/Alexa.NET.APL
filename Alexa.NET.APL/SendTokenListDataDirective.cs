using Alexa.NET.Response.Converters;
using Newtonsoft.Json;

namespace Alexa.NET.Response
{
    public class SendTokenListDataDirective : ListDataDirective
    {
        public const string DirectiveType = "Alexa.Presentation.APL.SendTokenListData";

        private static readonly object directiveadd = new object();

        public static void AddSupport()
        {
            lock (directiveadd)
            {
                if (!DirectiveConverter.TypeFactories.ContainsKey(DirectiveType))
                {
                    DirectiveConverter.TypeFactories.Add(DirectiveType, () => new SendTokenListDataDirective());
                }
            }
        }

        public override string Type => DirectiveType;

        [JsonProperty("pageToken")]
        public string PageToken { get; set; }

        [JsonProperty("nextPageToken",NullValueHandling = NullValueHandling.Ignore)]
        public string NextPageToken { get; set; }
    }
}