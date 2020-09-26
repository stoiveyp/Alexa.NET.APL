using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.Response.APL;

namespace Alexa.NET.APL.Extensions.Backstack
{
    public class BackstackExtension:APLExtension
    {
        public const string URL = "aplext:backstack:10";

        public BackstackExtension()
        {
            Uri = URL;
        }

        public BackstackExtension(string name):this()
        {
            Name = name;
        }
    }
}
