using System.Linq;
using Alexa.NET.Request.Type;

namespace Alexa.NET.Request
{
    public class LoadTokenListDataRequestHandler : IRequestTypeConverter
    {
        public bool CanConvert(string requestType)
        {
            return requestType == LoadTokenListDataRequest.RequestType;
        }

        public Request.Type.Request Convert(string requestType)
        {
            return new LoadTokenListDataRequest();
        }

        private static readonly object directiveadd = new object();

        public void AddToRequestConverter()
        {
            lock (directiveadd)
            {
                if (RequestConverter.RequestConverters.Where(rc => rc != null)
                    .All(rc => rc.GetType() != typeof(LoadTokenListDataRequestHandler)))
                {
                    RequestConverter.RequestConverters.Add(this);
                }
            }
        }
    }
}