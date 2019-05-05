using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Alexa.NET.APL.Commands;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alexa.NET.APL.JsonConverter
{
    public class APLCommandConverter:Newtonsoft.Json.JsonConverter
    {
        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {

            var jObject = JObject.Load(reader);
            var commandType = jObject.Value<string>("type");
            object target = GetCommand(commandType);
            if (target != null)
            {
                serializer.Populate(jObject.CreateReader(), target);
                return target;
            }

            throw new ArgumentOutOfRangeException($"Command type {commandType} not supported");
        }

        private APLCommand GetCommand(string commandType)
        {
            switch (commandType)
            {
                case nameof(Idle):
                    return new Idle();
                case nameof(Sequential):
                    return new Sequential();
                case nameof(Parallel):
                    return new Parallel();
                case nameof(SendEvent):
                    return new SendEvent();
                case nameof(SpeakItem):
                    return new SpeakItem();
                case nameof(Scroll):
                    return new Scroll();
                case nameof(ScrollToIndex):
                    return new ScrollToIndex();
                case nameof(SetPage):
                    return new SetPage();
                case nameof(AutoPage):
                    return new AutoPage();
                case nameof(PlayMedia):
                    return new PlayMedia();
                case nameof(ControlMedia):
                    return new ControlMedia();
                case nameof(SetState):
                    return new SetState();
                case nameof(SetValue):
                    return new SetValue();
            }

            return null;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType.GetTypeInfo().IsSubclassOf(typeof(APLCommand));
        }
    }
}
