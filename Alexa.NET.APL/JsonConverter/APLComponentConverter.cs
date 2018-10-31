using System;
using Alexa.NET.APL.Components;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alexa.NET.APL.JsonConverter
{
    public class APLComponentConverter : Newtonsoft.Json.JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // Load JObject from stream
            var jObject = JObject.Load(reader);
            var componentType = jObject.Value<string>("type");
            object target = GetComponent(componentType);
            if (target != null)
            {
                serializer.Populate(jObject.CreateReader(), target);
                return target;
            }

            throw new ArgumentOutOfRangeException($"Component type {componentType} not supported");
        }

        private APLComponent GetComponent(string type)
        {
            switch (type)
            {
                case Container.ComponentType:
                    return new Container();
                case Text.ComponentType:
                    return new Text();
                default:
                    return null;
            }
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType.IsSubclassOf(typeof(APLComponent));
        }
    }
}