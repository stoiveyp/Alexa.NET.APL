using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alexa.NET.Request
{
    public static class APLInterface
    {
        public const string InterfaceName = "Alexa.Presentation.APL";

        public static bool APLSupported(this SkillRequest request)
        {
            return Supported(request);
        }

        public static bool Supported(SkillRequest request)
        {
            return request.Context.System.Device.SupportedInterfaces.ContainsKey(InterfaceName);
        }

        public static APLInterfaceDetails APLInterfaceDetails(this SkillRequest request)
        {
            var raw = GetAPLInterfaceObject(request);
            return raw == null ? null : JsonConvert.DeserializeObject<APLInterfaceDetails>(raw.ToString());
        }

        private static object GetAPLInterfaceObject(SkillRequest request)
        {
            var interfaces = request.Context.System.Device.SupportedInterfaces;
            return interfaces.ContainsKey(InterfaceName) ? interfaces[InterfaceName] : null;
        }
    }
}
