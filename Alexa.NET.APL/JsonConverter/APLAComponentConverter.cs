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
            var target = GetGesture(commandType);
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
            {nameof(Audio), typeof(Audio.Audio)},
            {nameof(Mixer), typeof(Mixer)},
            {nameof(Selector), typeof(Selector)},
            {nameof(Sequencer), typeof(Sequencer)},
            {nameof(Silence), typeof(Silence)},
            {nameof(Speech), typeof(Speech)}
        };

        private APLAComponent GetGesture(string commandType)
        {
            return (APLAComponent)(
                APLAComponentLookup.ContainsKey(commandType)
                    ? Activator.CreateInstance(APLAComponentLookup[commandType])
                    : null);
        }
    }
}
