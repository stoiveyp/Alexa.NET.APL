using Newtonsoft.Json;

namespace Alexa.NET.Request
{
    public static class APLAInterface
    {
        public const string InterfaceName = "Alexa.Presentation.APLA";

        public static bool APLASupported(this SkillRequest request)
        {
            return Supported(request);
        }

        public static bool Supported(SkillRequest request)
        {
            return request.Context.System.Device.SupportedInterfaces.ContainsKey(InterfaceName);
        }
    }
}