using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL
{
    public class APLValue
    {
        public string Expression { get; set; }

        public APLValue<T> ForExpression<T>(string expression)
        {
            return new APLValue<T>{Expression = expression};
        }

        public virtual object GetValue()
        {
            return null;
        }
    }

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
