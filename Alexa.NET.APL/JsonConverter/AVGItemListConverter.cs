using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.VectorGraphics;
using Newtonsoft.Json;

namespace Alexa.NET.APL.JsonConverter
{
    public class AVGItemListConverter:SingleOrListConverter<IAVGItem>
    {
        private AVGItemConverter _converter = new AVGItemConverter();
        protected override JsonToken SingleToken => JsonToken.StartObject;
        protected override void ReadSingle(JsonReader reader, JsonSerializer serializer, List<IAVGItem> list)
        {
            var value = (IAVGItem) _converter.ReadJson(reader, typeof(IAVGItem), null, serializer);
            serializer.Populate(reader, value);
            list.Add(value);
        }
    }
}
