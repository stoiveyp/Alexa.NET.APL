using System;
using System.Collections.Generic;
using Alexa.NET.APL.Audio;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alexa.NET.APL.JsonConverter
{
    public class APLAComponentConverter: JsonConverter<APLAComponent>
    {
        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, APLAComponent value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override APLAComponent ReadJson(JsonReader reader, Type objectType, APLAComponent existingValue, bool hasExistingValue,
            JsonSerializer serializer)
        {
            var jObject = JObject.Load(reader);
            var commandType = jObject.Value<string>("type");
            var target = GetComponent(commandType);
            if (target != null)
            {
                jObject.Move("item", "items");
                serializer.Populate(jObject.CreateReader(), target);
                return target;
            }

            throw new ArgumentOutOfRangeException($"Command type {commandType} not supported");
        }

        public static Dictionary<string, Type> APLAComponentLookup = new Dictionary<string, Type>
        {

        };

        private APLAComponent GetComponent(string type)
        {
            if (APLAComponentLookup.ContainsKey(type))
            {
                return (APLAComponent)Activator.CreateInstance(APLAComponentLookup[type]);
            }

            var resultingType = Type.GetType("Alexa.NET.APL.Audio." + type);
            if (resultingType != null)
            {
                if (!APLAComponentLookup.ContainsKey(type))
                {
                    APLAComponentLookup.Add(type, resultingType);
                }

                return (APLAComponent)Activator.CreateInstance(resultingType);
            }

            return null;
        }
    }
}
