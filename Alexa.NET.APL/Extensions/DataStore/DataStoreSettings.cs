using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Extensions.DataStore
{
    public class DataStoreSettings
    {
        [JsonProperty("dataBindings")] public List<DataBinding> DataBindings { get; set; } = new();
    }
}
