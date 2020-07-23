using System.Collections.Generic;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.JsonConverter
{
    public class APLAComponentListConverter : SingleOrListConverter<APLAComponent>
    {
        public APLAComponentListConverter() : this(false) { }

        public APLAComponentListConverter(bool alwaysOutputArray) : base(alwaysOutputArray) { }

        private readonly APLAComponentConverter _converter = new APLAComponentConverter();
        protected override JsonToken SingleToken => JsonToken.StartObject;

        protected override void ReadSingle(JsonReader reader, JsonSerializer serializer, List<APLAComponent> list)
        {
            var value = (APLAComponent)_converter.ReadJson(reader, typeof(APLComponent), null, serializer);
            list.Add(value);
        }
    }
}