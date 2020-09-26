using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alexa.NET.Response.APL
{
    public class APLDocumentSettings
    {
        public APLDocumentSettings() { }

        public APLDocumentSettings(int idleTimeout)
        {
            IdleTimeout = idleTimeout;
        }

        [JsonProperty("idleTimeout",NullValueHandling = NullValueHandling.Ignore)]
        public int? IdleTimeout { get; set; }

        [JsonExtensionData]
        public Dictionary<string,object> OtherSettings { get; set; }

        public void Add(string name, object settings)
        {
            if (OtherSettings == null)
            {
                OtherSettings = new Dictionary<string, object>();
            }

            OtherSettings.Add(name, settings);
        }
    }
}