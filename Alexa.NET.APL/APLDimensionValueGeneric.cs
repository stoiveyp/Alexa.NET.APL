using System;
using System.Collections.Generic;
using System.Text;

namespace Alexa.NET.APL
{
    public class APLDimensionValue<T> : APLValue<T> where T : Dimension
    {
        public APLDimensionValue() { }

        public APLDimensionValue(T dimension) : base(dimension) { }

        public override object GetValue()
        {
            return Value.GetValue();
        }
    }
}
