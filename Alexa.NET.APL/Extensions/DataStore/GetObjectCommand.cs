using Newtonsoft.Json;

namespace Alexa.NET.APL.Extensions.DataStore
{
    public class GetObjectCommand:APLCommand
    {
        private readonly string _extensionName;

        public static GetObjectCommand For(DataStoreExtension extension)
        {
            return new GetObjectCommand(extension.Name);
        }

        public static GetObjectCommand For(DataStoreExtension extension, string @namespace, string key, string token = null)
        {
            return new GetObjectCommand(extension.Name, @namespace, key, token);
        }

        public GetObjectCommand(string extensionName)
        {
            _extensionName = extensionName;
        }

        public GetObjectCommand(string extensionName, string @namespace, string key, string token = null):this(extensionName)
        {
            Namespace = @namespace;
            Key = key;
            Token = token;
        }

        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("token",NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        public override string Type => $"{_extensionName}:GetObject";
    }
}
