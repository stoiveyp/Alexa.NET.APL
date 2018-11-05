namespace Alexa.NET.APL
{
    public class APLValue
    {
        public string Expression { get; set; }

        public virtual object GetValue()
        {
            return null;
        }

        public static APLValue<T> To<T>(string expression)
        {
            return new APLValue<T>{Expression=expression};
        }
    }
}
