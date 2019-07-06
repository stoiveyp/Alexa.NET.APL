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
        protected override void ReadSingle(JsonReader reader, JsonSerializer serializer, List<APLCommand> list)
        {
            var value = (APLCommand)_converter.ReadJson(reader, typeof(IAVGItem), null, serializer);
            serializer.Populate(reader, value);
            list.Add(value);
        }
    }
}
