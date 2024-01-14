using System;
using System.Collections.Generic;
using System.Reflection;
using Alexa.NET.APL.Commands;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alexa.NET.APL.JsonConverter
{
    public class APLCommandConverter : Newtonsoft.Json.JsonConverter
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

        public static Dictionary<string, Type> APLCommandLookup = new Dictionary<string, Type>
        {
            {nameof(Idle), typeof(Idle)},
            {nameof(Sequential), typeof(Sequential)},
            {nameof(Parallel), typeof(Parallel)},
            {nameof(SendEvent), typeof(SendEvent)},
            {nameof(SpeakItem), typeof(SpeakItem)},
            {nameof(SpeakList), typeof(SpeakList)},
            {nameof(Scroll), typeof(Scroll)},
            {nameof(ScrollToComponent), typeof(ScrollToComponent)},
            {nameof(ScrollToIndex), typeof(ScrollToIndex)},
            {nameof(SetPage), typeof(SetPage)},
            {nameof(AutoPage), typeof(AutoPage)},
            {nameof(PlayMedia), typeof(PlayMedia)},
            {nameof(ControlMedia), typeof(ControlMedia)},
            {nameof(SetValue), typeof(SetValue)},
            {nameof(AnimateItem),typeof(AnimateItem) },
            {nameof(OpenURL),typeof(OpenURL) },
            {nameof(SetFocus),typeof(SetFocus) },
            {nameof(ClearFocus),typeof(ClearFocus) },
            {nameof(Select),typeof(Select) },
            {nameof(Finish),typeof(Finish) },
            {nameof(Reinflate),typeof(Reinflate) },
            {nameof(InsertItem), typeof(InsertItem)},
            {nameof(RemoveItem), typeof(RemoveItem)}
        };

        private APLCommand GetCommand(string commandType)
        {
            return (APLCommand)(
                APLCommandLookup.ContainsKey(commandType)
                    ? Activator.CreateInstance(APLCommandLookup[commandType])
                    : new CustomCommand(commandType));
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType.GetTypeInfo().IsSubclassOf(typeof(APLCommand));
        }
    }
}
