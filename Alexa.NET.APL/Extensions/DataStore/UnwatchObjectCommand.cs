using Newtonsoft.Json;

namespace Alexa.NET.APL.Extensions.DataStore
{
    public class UnwatchObjectCommand:APLCommand
    {
        private readonly string _extensionName;

        public static UnwatchObjectCommand For(DataStoreExtension extension)
        {
            return new UnwatchObjectCommand(extension.Name);
        }

        public static UnwatchObjectCommand For(DataStoreExtension extension, string @namespace, string key)
        {
            return new UnwatchObjectCommand(extension.Name, @namespace, key);
        }

        public UnwatchObjectCommand(string extensionName)
        {
            _extensionName = extensionName;
        }

        public UnwatchObjectCommand(string extensionName, string @namespace, string key):this(extensionName)
        {
            Namespace = @namespace;
            Key = key;
        }

        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        public override string Type => $"{_extensionName}:UnwatchObject";
    }
}
