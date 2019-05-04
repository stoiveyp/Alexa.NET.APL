namespace Alexa.NET.APL
{
    public class APLDimensionValue : APLDimensionValue<Dimension>
    {
        public APLDimensionValue()
        {
        }

        public APLDimensionValue(Dimension dimension) : base(dimension)
        {
        }

        public APLDimensionValue(string value) : this(Dimension.From(value))
        {
        }

        public static implicit operator APLDimensionValue(int value)
        {
            return new APLDimensionValue(new AbsoluteDimension(value, "dp"));
        }

        public static implicit operator APLDimensionValue(string value)
        {
            return new APLDimensionValue(value);
        }

        public static implicit operator APLDimensionValue(Dimension value)
        {
            return new APLDimensionValue(value);
        }
    }
}