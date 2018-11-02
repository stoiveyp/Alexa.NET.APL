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
            if (!string.IsNullOrWhiteSpace(apl.Expression))
            {
                serializer.Serialize(writer, apl.Expression);
            }
            else if (value is APLValue<Dimension> dimension)
            {
                serializer.Serialize(writer, dimension.GetValue());
            }
            else
            {
                serializer.Serialize(writer, apl.GetValue());
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.Value == null)
            {
                return null;
            }

            var instance = Activator.CreateInstance(objectType);
            var genericType = objectType.GenericTypeArguments.First();
            if (genericType.IsInstanceOfType(reader.Value))
            {
                objectType.GetProperty("Value").SetValue(instance, reader.Value);
            }
            else if (typeof(Dimension).IsAssignableFrom(genericType))
            {
                var value = reader.Value?.ToString();
                var dimension = ToDimension(value);
                objectType.GetProperty("Value").SetValue(instance, dimension);
            }
            else
            {
                ((APLValue)instance).Expression = reader.Value.ToString();
            }

            return instance;
        }

        private Dimension ToDimension(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return null;
            }

            if (value.Last() == '%')
            {
                return new RelativeDimension(int.Parse(value.Substring(0, value.Length - 1)));
            }

            if (char.IsNumber(value[0]))
            {
                var split = value.Length;
                for (var splitTest = 0; splitTest < value.Length; splitTest++)
                {
                    if (!char.IsDigit(value[splitTest]))
                    {
                        split = splitTest;
                        break;
                    }
                }

                return new AbsoluteDimension(int.Parse(value.Substring(0, split)), value.Substring(split));
            }

            return new SpecialDimension(value);
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType.IsSubclassOf(typeof(APLValue));
        }
    }
}
