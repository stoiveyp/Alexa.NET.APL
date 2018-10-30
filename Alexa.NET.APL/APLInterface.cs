using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Alexa.NET.Request
{
    public class APLInterface
    {
        public const string InterfaceName = "Alexa.Presentation.APL";

        public static bool Supported(SkillRequest request)
        {
            return request.Context.System.Device.SupportedInterfaces.ContainsKey(InterfaceName);
        }
    }
}
