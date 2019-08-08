using System;
using System.Linq;

namespace Alexa.NET.APL
{
    public class APLValue
    {
        public string Expression { get; set; }

        public virtual object GetValue()
        {
            return null;
        }

        private static Type[] _invalidTypes = new[]
        {
            typeof(AbsoluteDimension),
            typeof(RelativeDimension),
            typeof(Dimension),
            typeof(SpecialDimension),
            typeof(APLAbsoluteDimensionValue),
            typeof(APLDimensionValue)
        };

        public static APLValue<T> To<T>(string expression)
        {
            if (_invalidTypes.Contains(typeof(T)))
            {
                throw new InvalidOperationException("Unable to use APLValue.To with Dimensions, please use new APLAbsoluteDimensionValue(string value) or new APLDimensionValue(string value) as appropriate");
            }
            return new APLValue<T>{Expression=expression};
        }
    }
}
