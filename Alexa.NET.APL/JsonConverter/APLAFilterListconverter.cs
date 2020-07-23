using System.Collections.Generic;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.JsonConverter
{
    public class APLAFilterListConverter : SingleOrListConverter<APLAFilter>
    {
        public APLAFilterListConverter() : this(false) { }

        public APLAFilterListConverter(bool alwaysOutputArray) : base(alwaysOutputArray) { }

        private readonly APLAFilterConverter _converter = new APLAFilterConverter();
        protected override JsonToken SingleToken => JsonToken.StartObject;

        protected override void ReadSingle(JsonReader reader, JsonSerializer serializer, List<APLAFilter> list)
        {
            var value = (APLAFilter)_converter.ReadJson(reader, typeof(APLComponent), null, serializer);
            list.Add(value);
        }
    }
}