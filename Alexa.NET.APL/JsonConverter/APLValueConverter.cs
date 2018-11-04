using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
            var objectTypeInfo = objectType.GetTypeInfo();
            if (instance is APLDimensionValue)
            {
                objectTypeInfo.GetProperty("Value").SetValue(instance, Dimension.From(reader.Value.ToString()));
                return instance;
            }

            var genericType = objectType.GenericTypeArguments.First().GetTypeInfo();
            if (genericType.IsInstanceOfType(reader.Value))
            {
                objectTypeInfo.GetProperty("Value").SetValue(instance, reader.Value);
            }
            else
            {
                ((APLValue)instance).Expression = reader.Value.ToString();
            }

            return instance;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType.GetTypeInfo().IsSubclassOf(typeof(APLValue));
        }
    }
}
