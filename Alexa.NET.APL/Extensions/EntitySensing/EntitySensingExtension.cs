using System;
using System.Collections.Generic;
using System.Text;

namespace Alexa.NET.APL.Extensions.EntitySensing
{
    public class EntitySensingExtension:APLExtension
    {
        public const string URL = "alexaext:entitysensing:10";
        //public const string DeviceStateChangedEventName = "OnDeviceStateChanged";

        public EntitySensingExtension()
        {
            Uri = URL;
        }

        public EntitySensingExtension(string name) : this()
        {
            Name = name;
        }

        //public void OnDeviceStateChanged(APLDocumentBase document, APLValue<IList<APLCommand>> commands)
        //{
        //    document.AddHandler($"{Name}:{DeviceStateChangedEventName}", commands);
        //}
    }
}
