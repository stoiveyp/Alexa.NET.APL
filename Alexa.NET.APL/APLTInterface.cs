using Newtonsoft.Json;

namespace Alexa.NET.Request
{
    public static class APLTInterface
    {
        public const string InterfaceName = "Alexa.Presentation.APLT";

        public static bool APLTSupported(this SkillRequest request)
        {
            return Supported(request);
        }

        public static bool Supported(SkillRequest request)
        {
            return request.Context.System.Device.SupportedInterfaces.ContainsKey(InterfaceName);
        }

        public static APLInterfaceDetails APLTInterfaceDetails(this SkillRequest request)
        {
            var raw = GetAPLTInterfaceObject(request);
            return raw == null ? null : JsonConvert.DeserializeObject<APLInterfaceDetails>(raw.ToString());
        }

        private static object GetAPLTInterfaceObject(SkillRequest request)
        {
            var interfaces = request.Context.System.Device.SupportedInterfaces;
            return interfaces.ContainsKey(InterfaceName) ? interfaces[InterfaceName] : null;
        }
    }
}