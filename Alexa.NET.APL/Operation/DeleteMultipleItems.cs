using Newtonsoft.Json;

namespace Alexa.NET.APL.Operation
{
    public class DeleteMultipleItems : Operation
    {
        public DeleteMultipleItems() { }

        public DeleteMultipleItems(int index, int count)
        {
            Index = index;
        }

        public const string OperationType = "DeleteMultipleItems";
        public override string Type => OperationType;

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }
}