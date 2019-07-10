using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.VectorGraphics;
using Newtonsoft.Json;

namespace Alexa.NET.APL.JsonConverter
{
    public class APLCommandListConverter : SingleOrListConverter<APLCommand>
    {
        public APLCommandListConverter() : this(false) { }

        public APLCommandListConverter(bool alwaysOutputArray) : base(alwaysOutputArray) { }

        private readonly APLCommandConverter _converter = new APLCommandConverter();
        protected override JsonToken SingleToken => JsonToken.StartObject;

        protected override void ReadSingle(JsonReader reader, JsonSerializer serializer, List<APLCommand> list)
        {
            var value = (APLCommand)_converter.ReadJson(reader, typeof(APLCommand), null, serializer);
            list.Add(value);
        }
    }
}
