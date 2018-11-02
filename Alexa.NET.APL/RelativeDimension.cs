namespace Alexa.NET.APL
{
    public class RelativeDimension:Dimension
    {
        public RelativeDimension() { }

        public RelativeDimension(int percentage)
        {
            Percentage = percentage;
        }

        public int Percentage { get; set; }

        public override object GetValue()
        {
            return $"{Percentage}%";
        }
    }
}