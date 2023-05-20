using System.Linq;
using Alexa.NET.Request;
using Alexa.NET.Request.Type;

namespace Alexa.NET.APL.DataStore.PackageManager
{
    public class UpdateRequestHandler : IRequestTypeConverter
    {
        public bool CanConvert(string requestType)
        {
            return requestType == UpdateRequest.RequestType;
        }

        public Request.Type.Request Convert(string requestType)
        {
            return new UpdateRequest();
        }

        private static readonly object directiveadd = new object();

        public void AddToRequestConverter()
        {
            lock (directiveadd)
            {
                if (RequestConverter.RequestConverters.Where(rc => rc != null)
                    .All(rc => rc.GetType() != typeof(UpdateRequestHandler)))
                {
                    RequestConverter.RequestConverters.Add(this);
                }
            }
        }
    }
}