using System;
using System.Collections.Generic;
using Alexa.NET.APL.Audio;
using Alexa.NET.APL.Audio.Filters;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alexa.NET.APL.JsonConverter
{
    public class APLAFilterConverter: JsonConverter<APLAFilter>
    {
        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, APLAFilter value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override APLAFilter ReadJson(JsonReader reader, Type objectType, APLAFilter existingValue, bool hasExistingValue,
            JsonSerializer serializer)
        {
            var jObject = JObject.Load(reader);
            var commandType = jObject.Value<string>("type");
            var target = GetGesture(commandType);
            if (target != null)
            {
                serializer.Populate(jObject.CreateReader(), target);
                return target;
            }

            throw new ArgumentOutOfRangeException($"Command type {commandType} not supported");
        }

        public static Dictionary<string, Type> APLAFilterLookup = new Dictionary<string, Type>
        {
            {nameof(Trim), typeof(Trim)},
            {nameof(FadeIn), typeof(FadeIn)},
            {nameof(FadeOut), typeof(FadeOut)},
            {nameof(Volume), typeof(Volume)}
        };

        private APLAFilter GetGesture(string commandType)
        {
            return (APLAFilter)(
                APLAFilterLookup.ContainsKey(commandType)
                    ? Activator.CreateInstance(APLAFilterLookup[commandType])
                    : null);
        }
    }
}