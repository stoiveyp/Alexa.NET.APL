using Alexa.NET.Request;
using Alexa.NET.Response;

namespace Alexa.NET.APL
{
    public static class APLSupport
    {
        public static void Add()
        {
            RenderDocumentDirective.AddSupport();
            ExecuteCommandsDirective.AddSupport();
            SendIndexListDataDirective.AddSupport();
            UpdateIndexListDataDirective.AddSupport();
            new UserEventRequestHandler().AddToRequestConverter();
            new LoadIndexListDataRequestHandler().AddToRequestConverter();
            new LoadTokenListDataRequestHandler().AddToRequestConverter();
            new RuntimeErrorRequestHandler().AddToRequestConverter();
        }
    }
}
