using System.Linq;
using Alexa.NET.Request.Type;

namespace Alexa.NET.Request
{
    public class LoadIndexListDataRequestHandler : IRequestTypeConverter
    {
        public bool CanConvert(string requestType)
        {
            return requestType == LoadIndexListDataRequest.RequestType;
        }

        public Request.Type.Request Convert(string requestType)
        {
            return new LoadIndexListDataRequest();
        }

        private static readonly object directiveadd = new object();

        public void AddToRequestConverter()
        {
            lock (directiveadd)
            {
                if (RequestConverter.RequestConverters.Where(rc => rc != null)
                    .All(rc => rc.GetType() != typeof(LoadIndexListDataRequestHandler)))
                {
                    RequestConverter.RequestConverters.Add(this);
                }
            }
        }
    }
}