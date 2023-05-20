using System.Linq;
using Alexa.NET.Request;
using Alexa.NET.Request.Type;

namespace Alexa.NET.APL.DataStore.PackageManager
{
    public class UsagesRemovedRequestHandler : IRequestTypeConverter
    {
        public bool CanConvert(string requestType)
        {
            return requestType == UsagesRemovedRequest.RequestType;
        }

        public Request.Type.Request Convert(string requestType)
        {
            return new UsagesRemovedRequest();
        }

        private static readonly object directiveadd = new object();

        public void AddToRequestConverter()
        {
            lock (directiveadd)
            {
                if (RequestConverter.RequestConverters.Where(rc => rc != null)
                    .All(rc => rc.GetType() != typeof(UsagesRemovedRequestHandler)))
                {
                    RequestConverter.RequestConverters.Add(this);
                }
            }
        }
    }
}