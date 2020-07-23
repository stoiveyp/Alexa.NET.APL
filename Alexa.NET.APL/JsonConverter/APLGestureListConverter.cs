using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alexa.NET.APL.JsonConverter
{
    public class APLGestureListConverter : SingleOrListConverter<APLGesture>
    {
        public APLGestureListConverter() : this(false) { }

        public APLGestureListConverter(bool alwaysOutputArray) : base(alwaysOutputArray) { }

        private readonly APLGestureConverter _converter = new APLGestureConverter();
        protected override JsonToken SingleToken => JsonToken.StartObject;

        protected override void ReadSingle(JsonReader reader, JsonSerializer serializer, List<APLGesture> list)
        {
            var value = (APLGesture)_converter.ReadJson(reader, typeof(APLGesture), null, serializer);
            list.Add(value);
        }
    }
}