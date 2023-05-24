using Newtonsoft.Json;

namespace Alexa.NET.APL.Extensions.DataStore
{
    public class UpdateArrayBindingRangeCommand:APLCommand
    {
        private readonly string _extensionName;

        public static UpdateArrayBindingRangeCommand For(DataStoreExtension extension)
        {
            return new UpdateArrayBindingRangeCommand(extension.Name);
        }

        public static UpdateArrayBindingRangeCommand For(DataStoreExtension extension, APLValue<string> dataBindingName, APLValue<int?> startIndex, APLValue<int?> endIndex)
        {
            return new UpdateArrayBindingRangeCommand(extension.Name, dataBindingName, startIndex, endIndex);
        }

        public UpdateArrayBindingRangeCommand(string extensionName)
        {
            _extensionName = extensionName;
        }

        public UpdateArrayBindingRangeCommand(string extensionName, APLValue<string> dataBindingName, APLValue<int?> startIndex, APLValue<int?> endIndex) :this(extensionName)
        {
            DataBindingName = dataBindingName;
            StartIndex = startIndex;
            EndIndex = endIndex;
        }

        [JsonProperty("dataBindingName",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> DataBindingName { get; set; }

        [JsonProperty("startIndex",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> StartIndex { get; set; }

        [JsonProperty("endIndex",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> EndIndex { get; set; }

        public override string Type => $"{_extensionName}:UpdateArrayBindingRange";
    }
}
