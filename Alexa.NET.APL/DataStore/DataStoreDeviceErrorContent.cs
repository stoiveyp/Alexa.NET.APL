using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alexa.NET.APL.DataStore
{
    public class DataStoreDeviceErrorContent : DataStoreErrorContent
    {
        [JsonProperty("commands", NullValueHandling = NullValueHandling.Ignore)]
        public IList<DataStoreCommand> Commands { get; set; }
    }
}