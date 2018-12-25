using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alexa.NET.APL.JsonConverter
{
    public abstract class SingleOrListConverter<TValue>:Newtonsoft.Json.JsonConverter
    {

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var list = (IList<TValue>)value;

            if (list.Count == 1)
            {
                serializer.Serialize(writer, list.First());
            }
            else
            {
                writer.WriteStartArray();

                foreach (var listitem in list)
                {
                    serializer.Serialize(writer, listitem);
                }

                writer.WriteEndArray();

            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var valueList = new List<TValue>();

            if (reader.TokenType == SingleToken)
            {
                ReadSingle(reader, serializer,valueList);
            }
            else
            {
                serializer.Populate(reader, valueList);
            }

            return valueList;
        }

        protected abstract JsonToken SingleToken { get; }
        protected abstract void ReadSingle(JsonReader reader, JsonSerializer serializer, List<TValue> list);

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(IList<TValue>);
        }
    }
}