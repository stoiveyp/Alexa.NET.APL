using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.JsonConverter;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class CustomComponent : APLComponent
    {
        public CustomComponent(string type)
        {
            Type = type;
        }

        public override string Type { get; }
    }
}
