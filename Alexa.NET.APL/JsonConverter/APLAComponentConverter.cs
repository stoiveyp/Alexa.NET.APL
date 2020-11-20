using System;
using System.Collections.Concurrent;
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
            var audioType = jObject.Value<string>("type");
            var target = APLAComponentLookup.GetLookupType<APLAComponent>(audioType, "Alexa.NET.APL.Audio", s => null);
            if (target != null)
            {
                jObject.Move("item", "items");
                serializer.Populate(jObject.CreateReader(), target);
                return target;
            }

            throw new ArgumentOutOfRangeException($"Command type {audioType} not supported");
        }

        public static ConcurrentDictionary<string, Type> APLAComponentLookup = new ConcurrentDictionary<string, Type>
        {

        };
    }
}
