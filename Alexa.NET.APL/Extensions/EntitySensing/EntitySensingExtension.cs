using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.Response.APL;

namespace Alexa.NET.APL.Extensions.EntitySensing
{
    public class EntitySensingExtension:APLExtension
    {
        public const string URL = "alexaext:entitysensing:10";
        public const string EntitySensingStateChangedEventName = "OnEntitySensingStateChanged";
        public const string PrimaryUserChangedEventName = "OnPrimaryUserChanged";

        public EntitySensingExtension()
        {
            Uri = URL;
        }

        public EntitySensingExtension(string name) : this()
        {
            Name = name;
        }

        public void OnEntitySensingStateChanged(APLDocumentBase document, APLValue<IList<APLCommand>> commands)
        { 
            document.AddHandler($"{Name}:{EntitySensingStateChangedEventName}", commands);
        }

        public void OnPrimaryUserChanged(APLDocumentBase document, APLValue<IList<APLCommand>> commands)
        {
            document.AddHandler($"{Name}:{PrimaryUserChangedEventName}", commands);
        }
    }
}
