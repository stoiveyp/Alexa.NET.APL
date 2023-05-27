using System.Linq;
using Alexa.NET.Request.Type;

namespace Alexa.NET.APL.DataStore
{
    public class DataStoreErrorHandler : IRequestTypeConverter
    {
        public bool CanConvert(string requestType)
        {
            return requestType == DataStoreErrorRequest.RequestType || requestType == "Alexa.DataStore.Error";
        }

        public Request.Type.Request Convert(string requestType)
        {
            return new DataStoreErrorRequest();
        }

        private static readonly object directiveadd = new object();

        public void AddToRequestConverter()
        {
            lock (directiveadd)
            {
                if (RequestConverter.RequestConverters.Where(rc => rc != null)
                    .All(rc => rc.GetType() != typeof(DataStoreErrorHandler)))
                {
                    RequestConverter.RequestConverters.Add(this);
                }
            }
        }
    }
}
