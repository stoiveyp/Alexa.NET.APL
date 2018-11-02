namespace Alexa.NET.APL
{
    public class APLValue
    {
        public string Expression { get; set; }

        public virtual object GetValue()
        {
            return null;
        }
    }
}
