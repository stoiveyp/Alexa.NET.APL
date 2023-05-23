using Newtonsoft.Json;

namespace Alexa.NET.APL.Extensions.DataStore
{
    internal class UpdateArrayBindingRangeCommand:APLCommand
    {
        private readonly string _extensionName;

        public static UpdateArrayBindingRangeCommand For(DataStoreExtension extension)
        {
            return new UpdateArrayBindingRangeCommand(extension.Name);
        }

        public static UpdateArrayBindingRangeCommand For(DataStoreExtension extension, string dataBindingName, int startIndex, int endIndex)
        {
            return new UpdateArrayBindingRangeCommand(extension.Name, dataBindingName, startIndex, endIndex);
        }

        public UpdateArrayBindingRangeCommand(string extensionName)
        {
            _extensionName = extensionName;
        }

        public UpdateArrayBindingRangeCommand(string extensionName, string dataBindingName, int startIndex, int endIndex) :this(extensionName)
        {
            DataBindingName = dataBindingName;
            StartIndex = startIndex;
            EndIndex = endIndex;
        }

        [JsonProperty("dataBindingName")]
        public string DataBindingName { get; set; }

        [JsonProperty("startIndex")]
        public int StartIndex { get; set; }

        [JsonProperty("endIndex")]
        public int EndIndex { get; set; }

        public override string Type => $"{_extensionName}:UpdateArrayBindingRange";
    }
}
