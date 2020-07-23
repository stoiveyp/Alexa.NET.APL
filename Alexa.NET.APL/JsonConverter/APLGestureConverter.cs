using System;
using System.Collections.Generic;
using Alexa.NET.APL.Gestures;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alexa.NET.APL.JsonConverter
{
    public class APLGestureConverter : Newtonsoft.Json.JsonConverter<APLGesture>
    {
        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, APLGesture value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override APLGesture ReadJson(JsonReader reader, Type objectType, APLGesture existingValue, bool hasExistingValue,
            JsonSerializer serializer)
        {
            var jObject = JObject.Load(reader);
            var commandType = jObject.Value<string>("type");
            var target = GetGesture(commandType);
            if (target != null)
            {
                jObject.Move("items", "item");
                serializer.Populate(jObject.CreateReader(), target);
                return target;
            }

            throw new ArgumentOutOfRangeException($"Command type {commandType} not supported");
        }

        public static Dictionary<string, Type> APLGestureLookup = new Dictionary<string, Type>
        {
            {nameof(DoublePress), typeof(DoublePress)},
            {nameof(LongPress), typeof(LongPress)},
            {nameof(SwipeAway), typeof(SwipeAway)}
        };

        private APLGesture GetGesture(string commandType)
        {
            return (APLGesture)(
                APLGestureLookup.ContainsKey(commandType)
                    ? Activator.CreateInstance(APLGestureLookup[commandType])
                    : null);
        }
    }
}