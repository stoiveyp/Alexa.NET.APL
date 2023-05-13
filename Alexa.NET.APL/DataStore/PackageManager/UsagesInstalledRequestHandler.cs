using System.Linq;
using Alexa.NET.Request;
using Alexa.NET.Request.Type;

namespace Alexa.NET.APL.DataStore.PackageManager
{
    public class UsagesInstalledRequestHandler : IRequestTypeConverter
    {
        public bool CanConvert(string requestType)
        {
            return requestType == UsagesInstalledRequest.RequestType;
        }

        public Request.Type.Request Convert(string requestType)
        {
            return new UsagesInstalledRequest();
        }

        private static readonly object directiveadd = new object();

        public void AddToRequestConverter()
        {
            lock (directiveadd)
            {
                if (RequestConverter.RequestConverters.Where(rc => rc != null)
                    .All(rc => rc.GetType() != typeof(UsagesInstalledRequestHandler)))
                {
                    RequestConverter.RequestConverters.Add(this);
                }
            }
        }
    }
}