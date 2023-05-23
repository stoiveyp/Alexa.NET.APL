using Newtonsoft.Json;

namespace Alexa.NET.APL.DataStore
{
    public class PutNamespace : DataStoreCommand
    {
        public const string CommandType = "PUT_NAMESPACE";

        public PutNamespace() : base(CommandType){}

        [JsonProperty("namespace")]
        public string Namespace { get; set; }
    }
}