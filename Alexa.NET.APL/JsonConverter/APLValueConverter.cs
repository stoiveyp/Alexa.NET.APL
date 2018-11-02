using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Alexa.NET.APL.JsonConverter
{
    public class APLValueConverter : Newtonsoft.Json.JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var apl = (APLValue)value;
            serializer.Serialize(writer, !string.IsNullOrWhiteSpace(apl.Expression) ? apl.Expression : apl.GetValue());
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.Value == null)
            {
                return null;
            }

            var instance = Activator.CreateInstance(objectType);

            if (instance is APLDimensionValue)
            {
                objectType.GetProperty("Value").SetValue(instance, Dimension.From(reader.Value.ToString()));
                return instance;
            }

            var genericType = objectType.GenericTypeArguments.First();
            if (genericType.IsInstanceOfType(reader.Value))
            {
                objectType.GetProperty("Value").SetValue(instance, reader.Value);
            }
            else
            {
                ((APLValue)instance).Expression = reader.Value.ToString();
            }

            return instance;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType.IsSubclassOf(typeof(APLValue));
        }
    }
}
