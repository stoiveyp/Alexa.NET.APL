using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL
{
    [JsonConverter(typeof(APLValueConverter))]
    public class APLValue<T> : APLValue
    {
        public APLValue() { }

        public APLValue(T value)
        {
            Value = value;
        }

        public T Value { get; set; }

        public override object GetValue()
        {
            return Value;
        }

        public static implicit operator APLValue<T>(T value)
        {
            return new APLValue<T>(value);
        }
    }
}
