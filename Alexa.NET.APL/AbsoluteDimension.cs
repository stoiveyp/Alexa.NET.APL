namespace Alexa.NET.APL
{
    public class AbsoluteDimension : Dimension
    {
        public AbsoluteDimension(int number, string unit)
        {
            Number = number;
            Unit = unit;
        }

        public string Unit { get; set; }

        public int Number { get; set; }

        public override object GetValue()
        {
            return $"{Number}{Unit}";
        }
    }
}