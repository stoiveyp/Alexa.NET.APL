using Newtonsoft.Json;

namespace Alexa.NET.APL.Operation
{
    public class DeleteItem : Operation
    {
        public DeleteItem() { }

        public DeleteItem(int index)
        {
            Index = index;
        }

        public const string OperationType = "DeleteItem";
        public override string Type => OperationType;

        [JsonProperty("index")]
        public int Index { get; set; }
    }
}