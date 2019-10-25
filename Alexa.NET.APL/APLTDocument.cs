using Alexa.NET.APL;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

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