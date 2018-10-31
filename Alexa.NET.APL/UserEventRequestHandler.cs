using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Alexa.NET.APL;
using Alexa.NET.Request.Type;

namespace Alexa.NET.Request
{
    public class UserEventRequestHandler:IRequestTypeConverter
    {
        public bool CanConvert(string requestType)
        {
            return requestType == UserEventRequest.RequestType;
        }

        public Request.Type.Request Convert(string requestType)
        {
            throw new NotImplementedException();
        }

        public void AddToRequestConverter()
        {
            if (RequestConverter.RequestConverters.Where(rc => rc != null).All(rc => rc.GetType() != typeof(UserEventRequestHandler)))
            {
                RequestConverter.RequestConverters.Add(this);
            }
        }
    }
}
