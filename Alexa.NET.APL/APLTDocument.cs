using Alexa.NET.APL;

namespace Alexa.NET.Response.APL
{
    public class APLTDocument : APLDocumentBase
    {
        public override string Type => "APLT";

        public APLTDocument():base(APLDocumentVersion.V1)
        {

        }
    }
}