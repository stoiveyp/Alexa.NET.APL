using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alexa.NET.APL.JsonConverter
{
    public class APLKeyboardHandlerConverter : SingleOrListConverter<APLKeyboardHandler>
    {
        public APLKeyboardHandlerConverter() : this(false) { }

        public APLKeyboardHandlerConverter(bool alwaysOutputArray) : base(alwaysOutputArray) { }

        private readonly APLCommandConverter _converter = new APLCommandConverter();
        protected override JsonToken SingleToken => JsonToken.StartObject;

        protected override void ReadSingle(JsonReader reader, JsonSerializer serializer, List<APLKeyboardHandler> list)
        {
            var value = (APLKeyboardHandler)_converter.ReadJson(reader, typeof(APLKeyboardHandler), null, serializer);
            list.Add(value);
        }
    }
}