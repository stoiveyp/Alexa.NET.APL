using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.JsonConverter
{
    public class APLComponentListConverter: SingleOrListConverter<APLComponent>
    {
        public APLComponentListConverter() : this(false) { }

        public APLComponentListConverter(bool alwaysOutputArray) : base(alwaysOutputArray) { }

        private readonly APLComponentConverter _converter = new APLComponentConverter();
        protected override JsonToken SingleToken => JsonToken.StartObject;

        protected override void ReadSingle(JsonReader reader, JsonSerializer serializer, List<APLComponent> list)
        {
            var value = (APLComponent)_converter.ReadJson(reader, typeof(APLComponent), null, serializer);
            list.Add(value);
        }
    }
}
