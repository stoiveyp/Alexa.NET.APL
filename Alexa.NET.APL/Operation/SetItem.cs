using Newtonsoft.Json;

namespace Alexa.NET.APL.Operation
{
    public class SetItem : Operation
    {
        public SetItem() { }

        public SetItem(int index, object item)
        {
            Index = index;
            Item = item;
        }

        public const string OperationType = "SetItem";
        public override string Type => OperationType;

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("item")]
        public object Item { get; set; }
    }
}