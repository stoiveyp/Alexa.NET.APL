namespace Alexa.NET.APL
{
    public class APLValue
    {
        public string Expression { get; set; }

        public APLValue<T> ForExpression<T>(string expression)
        {
            return new APLValue<T> { Expression = expression };
        }

        public virtual object GetValue()
        {
            return null;
        }
    }
}
