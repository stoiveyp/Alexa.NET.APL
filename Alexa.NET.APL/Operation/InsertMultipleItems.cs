using Newtonsoft.Json;

namespace Alexa.NET.APL.Operation
{
    public class InsertMultipleItems : Operation
    {
        public InsertMultipleItems() { }

        public InsertMultipleItems(int index, params object[] items)
        {
            Index = index;
            Items = items;
        }

        public const string OperationType = "InsertMultipleItems";
        public override string Type => OperationType;

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("items")]
        public object[] Items { get; set; }
    }
}