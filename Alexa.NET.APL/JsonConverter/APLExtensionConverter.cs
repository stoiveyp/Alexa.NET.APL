using System;
using System.Collections.Generic;
using Alexa.NET.APL.Extensions.Backstack;
using Alexa.NET.APL.Extensions.EntitySensing;
using Alexa.NET.APL.Extensions.SmartMotion;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alexa.NET.APL.JsonConverter
{
    public class APLExtensionConverter:JsonConverter<APLExtension>
    {
        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, APLExtension value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override APLExtension ReadJson(JsonReader reader, Type objectType, APLExtension existingValue, bool hasExistingValue,
            JsonSerializer serializer)
        {
            var jObject = JObject.Load(reader);
            var extensionUri = jObject.Value<string>("uri");
            var target = GetGesture(extensionUri);
            if (target != null)
            {
                serializer.Populate(jObject.CreateReader(), target);
                return target;
            }

            throw new ArgumentOutOfRangeException($"Extension Uri {extensionUri} not supported");
        }

        public static Dictionary<string, Type> APLExtensionLookup = new Dictionary<string, Type>
        {
            {BackstackExtension.URL, typeof(BackstackExtension)},
            {SmartMotionExtension.URL, typeof(SmartMotionExtension)},
            {EntitySensingExtension.URL, typeof(EntitySensingExtension)}
        };

        private APLExtension GetGesture(string commandType)
        {
            return (APLExtension)(
                APLExtensionLookup.ContainsKey(commandType)
                    ? Activator.CreateInstance(APLExtensionLookup[commandType])
                    : null);
        }
    }
}
