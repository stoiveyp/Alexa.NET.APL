using System.Collections.Generic;
using Alexa.NET.APL.VectorGraphics.Filters;
using Newtonsoft.Json;

namespace Alexa.NET.APL.JsonConverter
{
    public class AvgFilterListConverter : SingleOrListConverter<IAVGFilter>
    {
        public AvgFilterListConverter() : this(false) { }

        public AvgFilterListConverter(bool alwaysOutputArray) : base(alwaysOutputArray) { }

        private readonly IAVGFilterConverter _converter = new IAVGFilterConverter();
        protected override JsonToken SingleToken => JsonToken.StartObject;

        protected override void ReadSingle(JsonReader reader, JsonSerializer serializer, List<IAVGFilter> list)
        {
            var value = (IAVGFilter)_converter.ReadJson(reader, typeof(IAVGFilter), null, serializer);
            list.Add(value);
        }
    }
}