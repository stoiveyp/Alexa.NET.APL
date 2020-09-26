using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Extensions.EntitySensing
{
    public class EntitySensingSettings
    {
        [JsonProperty("entitySensingStateName", NullValueHandling = NullValueHandling.Ignore)]
        public string EntitySensingStateName { get; set; }

        [JsonProperty("primaryUserName", NullValueHandling = NullValueHandling.Ignore)]
        public string PrimaryUserName { get; set; }
    }
}
