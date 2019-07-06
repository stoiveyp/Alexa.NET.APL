using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.Response.APL;

namespace Alexa.NET.APL.Components
{
    public static class APLComponentExtensions
    {
        public static void AddResponsiveDesign(this APLDocument document)
        {
            Import.AlexaLayouts.Into(document);
        }
    }
}
