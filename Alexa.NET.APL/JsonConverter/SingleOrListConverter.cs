using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alexa.NET.APL.JsonConverter
{
    public abstract class SingleOrListConverter<TValue> : Newtonsoft.Json.JsonConverter
    {
        public bool AlwaysOutputArray { get; }

        protected SingleOrListConverter() : base() { }

        protected SingleOrListConverter(bool alwaysOutputArray)
        {
            AlwaysOutputArray = alwaysOutputArray;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            IList<TValue> list = null;
            if (value is IList<TValue> templist)
            {
                list = templist;
            }
            else if (value is APLValue<IList<TValue>> apl)
            {
                if (apl.Expression != null)
                {
                    serializer.Serialize(writer, apl.Expression);
                    return;
                }
                list = apl.Value;
            }

            if (!AlwaysOutputArray)
            {
                if (list == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }

                if (list.Count == 1)
                {
                    serializer.Serialize(writer, list.First());
                    return;
                }
            }

            writer.WriteStartArray();

            if (list != null)
            {
                foreach (var listitem in list)
                {
                    serializer.Serialize(writer, OutputArrayItem(listitem));
                }
            }

            writer.WriteEndArray();

        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var valueList = new List<TValue>();

           
            if (reader.TokenType == SingleToken)
            {
                ReadSingle(reader, serializer, valueList);
            }
            else if (reader.TokenType == JsonToken.String)
            { 
                return APLValue.To<IList<TValue>>(reader.Value.ToString());
            }
            else
            {
                serializer.Populate(reader, valueList);
            }

            if (objectType == typeof(APLValue<IList<TValue>>))
            {
                return new APLValue<IList<TValue>>(valueList);
            }
            return valueList;
        }

        protected abstract JsonToken SingleToken { get; }
        protected abstract void ReadSingle(JsonReader reader, JsonSerializer serializer, List<TValue> list);

        protected virtual object OutputArrayItem(TValue value)
        {
            return value;
        }
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(IList<TValue>) || objectType == typeof(APLValue<IList<TValue>>);
        }
    }
}