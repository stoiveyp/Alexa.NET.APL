using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL;
using Alexa.NET.Response.APL;
using Alexa.NET.Response.Converters;
using Newtonsoft.Json;

namespace Alexa.NET.Response
{
    public class RenderDocumentDirective : IDirective
    {
        private const string DirectiveType = "Alexa.Presentation.APL.RenderDocument";
        private const string APLTDirectiveType = "Alexa.Presentation.APLT.RenderDocument";
        private static readonly object directiveadd = new object();

        public static void AddSupport()
        {
            lock (directiveadd)
            {
                if (!DirectiveConverter.TypeFactories.ContainsKey(DirectiveType))
                {
                    DirectiveConverter.TypeFactories.Add(DirectiveType, () => new RenderDocumentDirective());
                }

                if (!DirectiveConverter.TypeFactories.ContainsKey(APLTDirectiveType))
                {
                    DirectiveConverter.TypeFactories.Add(APLTDirectiveType, () => new RenderDocumentDirective());
                }
            }
        }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type => Document is APLTDocument ? APLTDirectiveType : DirectiveType;

        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        [JsonProperty("document")]
        public APLDocumentBase Document { get; set; }

        [JsonProperty("datasources", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, APLDataSource> DataSources { get; set; }
    }
}
