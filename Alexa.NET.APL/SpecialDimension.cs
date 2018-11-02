namespace Alexa.NET.APL
{
    public class SpecialDimension:Dimension
    {
        public SpecialDimension(string value)
        {
            Value = value;
        }

        public string Value { get; set; }

        public override object GetValue()
        {
            return Value;
        }
    }
}