using Newtonsoft.Json;

namespace Alexa.NET.APL.Operation
{
    public class InsertItem : Operation
    {
        public InsertItem() { }

        public InsertItem(int index, object item)
        {
            Index = index;
            Item = item;
        }

        public const string OperationType = "InsertItem";
        public override string Type => OperationType;

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("item")]
        public object Item { get; set; }
    }
}