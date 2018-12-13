using System;
using System.Collections.Generic;
using System.Reflection;
using Alexa.NET.APL.Components;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alexa.NET.APL.JsonConverter
{
    public class APLComponentConverter : Newtonsoft.Json.JsonConverter
    {
        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {

        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // Load JObject from stream
            var jObject = JObject.Load(reader);
            var componentType = jObject.Value<string>("type");
            object target = GetComponent(componentType);
            if (target == null)
            {
                throw new ArgumentOutOfRangeException($"Component type {componentType} not supported");
            }

            serializer.Populate(jObject.CreateReader(), target);

            if (target is CustomComponent custom)
            {
                custom.Properties.Remove("type");
            }

            return target;

        }

        private APLComponent GetComponent(string type)
        {
            switch (type)
            {
                case nameof(Container):
                    return new Container();
                case nameof(Text):
                    return new Text();
                case nameof(Image):
                    return new Image();
                case nameof(Frame):
                    return new Frame();
                case nameof(ScrollView):
                    return new ScrollView();
                case nameof(Sequence):
                    return new Sequence();
                case nameof(TouchWrapper):
                    return new TouchWrapper();
                case nameof(Pager):
                    return new Pager();
                case nameof(Video):
                    return new Video();
                default:
                    return new CustomComponent(type);
            }
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType.GetTypeInfo().IsSubclassOf(typeof(APLComponent));
        }
    }
}