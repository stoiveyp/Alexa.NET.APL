using System;
using System.Linq;
using System.Reflection;
using Alexa.NET.APL.Commands;
using Alexa.NET.APL.VectorGraphics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alexa.NET.APL.JsonConverter
{
    public class AnimatedPropertyConverter : Newtonsoft.Json.JsonConverter
    {
        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {

        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jObject = JObject.Load(reader);
            var filterType = jObject.Value<string>("property");
            object target = GetAnimatedProperty(filterType);
            if (target == null)
            {
                throw new ArgumentOutOfRangeException($"Animated Property type {filterType} not supported");
            }

            try
            {
                serializer.Populate(jObject.CreateReader(), target);
            }
            catch (Exception)
            {
            }

            return target;

        }

        private AnimatedProperty GetAnimatedProperty(string type)
        {
            switch (type)
            {
                case "opacity":
                    return new AnimatedOpacity();
                case "transform":
                    return new AnimatedTransform();
                default:
                    return null;
            }
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(AnimatedProperty).GetTypeInfo().IsAssignableFrom(typeof(AnimatedProperty));
        }
    }
}