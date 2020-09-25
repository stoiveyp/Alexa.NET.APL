using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.Response.APL;

namespace Alexa.NET.APL.Extensions
{
    public class BackStack:APLExtension
    {
        public BackStack()
        {
            Uri = "aplext:backstack:10";
        }

        public BackStack(string name):this()
        {
            Name = name;
        }
    }
}
