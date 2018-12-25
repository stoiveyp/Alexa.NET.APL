using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.JsonConverter
{
    public class StyleValueListConverter:Newtonsoft.Json.JsonConverter
    {

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var list = (IList<StyleValue>) value;

            if (list.Count == 1)
            {
                serializer.Serialize(writer,list.First());
            }
            else
            {
                writer.WriteStartArray();

                foreach (var listitem in list)
                {
                    serializer.Serialize(writer,listitem);
                }

                writer.WriteEndArray();
                
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var valueList = new List<StyleValue>();

            if (reader.TokenType == JsonToken.StartObject)
            {
                var value = new StyleValue();
                serializer.Populate(reader,value);
                valueList.Add(value);
            }
            else
            {
                serializer.Populate(reader, valueList);
            }

            return valueList;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(IList<StyleValue>);
        }
    }
}
