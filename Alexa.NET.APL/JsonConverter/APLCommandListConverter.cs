using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.VectorGraphics;
using Newtonsoft.Json;

namespace Alexa.NET.APL.JsonConverter
{
    public class APLCommandListConverter : SingleOrListConverter<APLCommand>
    {
        private readonly APLCommandConverter _converter = new APLCommandConverter();
        protected override JsonToken SingleToken => JsonToken.StartObject;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return base.ReadJson(reader, objectType, existingValue, serializer);
        }

        protected override void ReadSingle(JsonReader reader, JsonSerializer serializer, List<APLCommand> list)
        {
            var value = (APLCommand)_converter.ReadJson(reader, typeof(APLCommand), null, serializer);
            list.Add(value);
        }
    }
}
