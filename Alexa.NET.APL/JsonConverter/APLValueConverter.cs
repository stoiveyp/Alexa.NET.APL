using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using Newtonsoft.Json;

namespace Alexa.NET.APL.JsonConverter
{
    public class APLValueEnumConverter<T> : APLValueConverter
    {
        private readonly Type EnumType = typeof(T);

        protected override object CorrectOutput(object value)
        {
            return ToEnumString(EnumType,value);
        }

        protected override object CorrectInput(object value)
        {
            return value is string ? ToEnum(EnumType,value.ToString()) : value;
        }

        public static string ToEnumString(Type enumType,object type)
        {
            var name = Enum.GetName(enumType, type);
            var enumMemberAttribute = ((EnumMemberAttribute[])enumType.GetTypeInfo().GetField(name).GetCustomAttributes(typeof(EnumMemberAttribute), true)).Single();
            return enumMemberAttribute.Value;
        }

        public static object ToEnum(Type enumType,string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return str;
            }

            foreach (var name in Enum.GetNames(enumType))
            {
                var enumMemberAttribute = ((EnumMemberAttribute[])enumType.GetTypeInfo().GetField(name).GetCustomAttributes(typeof(EnumMemberAttribute), true)).Single();
                if (enumMemberAttribute.Value == str) return (T)Enum.Parse(enumType, name);
            }
            
            return str;
        }
    }

    public class APLValueConverter : Newtonsoft.Json.JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var apl = (APLValue)value;
            serializer.Serialize(writer, !string.IsNullOrWhiteSpace(apl.Expression) ? apl.Expression : CorrectOutput(apl.GetValue()));
        }

        protected virtual object CorrectOutput(object value)
        {
            return value;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.Value == null && reader.TokenType != JsonToken.StartArray)
            {
                return null;
            }

            var instance = Activator.CreateInstance(objectType);
            var objectTypeInfo = objectType.GetTypeInfo();
            if (instance is APLDimensionValue apldimen)
            {
                apldimen.Value = Dimension.From(reader.Value.ToString());
                return instance;
            }

            if (instance is APLAbsoluteDimensionValue abs)
            {
                abs.Value = (AbsoluteDimension)Dimension.From(reader.Value.ToString());
                return instance;
            }

            var genericType = objectType.GenericTypeArguments.First();

            genericType = Nullable.GetUnderlyingType(genericType) ?? genericType;
            
            var realInput = reader.TokenType == JsonToken.StartArray ? CreateList(reader,serializer,genericType) : CorrectInput(reader.Value);
            var realInputType = realInput.GetType();

            if (IsIntType(genericType) && IsIntType(realInputType))
            {
                objectTypeInfo.GetProperty("Value").SetValue(instance, Convert.ChangeType(realInput,genericType));
            }
            else if (genericType.GetTypeInfo().IsAssignableFrom(realInputType))
            {
                objectTypeInfo.GetProperty("Value").SetValue(instance, realInput);
            }
            else
            {
                ((APLValue)instance).Expression = reader.Value?.ToString();
            }

            return instance;
        }

        private object CreateList(JsonReader reader, JsonSerializer serializer, Type genericType)
        {
            return serializer.Deserialize(reader,
                typeof(List<>).MakeGenericType(genericType.GenericTypeArguments.First()));
        }

        private static bool IsIntType(Type type)
        {
            return type == typeof(int) || type == typeof(long) || type == typeof(short);
        }

        protected virtual object CorrectInput(object value)
        {
            return value;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType.GetTypeInfo().IsSubclassOf(typeof(APLValue));
        }
    }
}
