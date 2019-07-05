namespace Alexa.NET.APL
{
    public class APLAbsoluteDimensionValue : APLDimensionValue<AbsoluteDimension>
    {
        public APLAbsoluteDimensionValue()
        {
        }

        public APLAbsoluteDimensionValue(AbsoluteDimension dimension) : base(dimension)
        {
        }

        public APLAbsoluteDimensionValue(int number, string unit) : this(new AbsoluteDimension(number,unit))
        {
        }

        public static implicit operator APLAbsoluteDimensionValue(AbsoluteDimension value)
        {
            return new APLAbsoluteDimensionValue(value);
        }

        public static implicit operator APLAbsoluteDimensionValue(int value)
        {
            return new APLAbsoluteDimensionValue(value,"dp");
        }
    }
}