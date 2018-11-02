namespace Alexa.NET.APL
{
    public class APLDimensionValue : APLValue<Dimension>
    {
        public APLDimensionValue() { }

        public APLDimensionValue(Dimension dimension) : base(dimension) { }

        public APLDimensionValue(string value):this(Dimension.From(value))
        {
        }

        public override object GetValue()
        {
            return Value.GetValue();
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