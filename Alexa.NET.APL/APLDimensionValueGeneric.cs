using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alexa.NET.APL
{
    public class APLDimensionValue<T> : APLValue<T> where T : Dimension
    {
        public APLDimensionValue() { }

        public APLDimensionValue(T dimension) : base(dimension) { }

        public override object GetValue()
        {
            var value = Value.GetValue().ToString();
            if (value.All(char.IsDigit))
            {
                return int.Parse(value);
            }

            return value;
        }
    }
}
