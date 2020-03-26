using System;
using Alexa.NET.APL.Operation;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alexa.NET.APL.JsonConverter
{
    public class OperationConverter : Newtonsoft.Json.JsonConverter<Operation.Operation>
    {
        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, Operation.Operation value, JsonSerializer serializer)
        {

        }

        public override Operation.Operation ReadJson(JsonReader reader, Type objectType, Operation.Operation existingValue, bool hasExistingValue,
            JsonSerializer serializer)
        {
            // Load JObject from stream
            var jObject = JObject.Load(reader);

            var target = GetOperation(jObject.Value<string>("type"));
            serializer.Populate(jObject.CreateReader(), target);
            return target;
        }

        private static Operation.Operation GetOperation(string value)
        {
            return value switch
            {
                InsertItem.OperationType => new InsertItem(),
                InsertMultipleItems.OperationType => new InsertMultipleItems(),
                SetItem.OperationType => new SetItem(),
                DeleteItem.OperationType => new DeleteItem(),
                DeleteMultipleItems.OperationType => new DeleteMultipleItems(),
                _ => (Operation.Operation) null
            };
        }
    }
}
