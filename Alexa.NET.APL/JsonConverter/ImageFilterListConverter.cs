using System.Collections.Generic;
using Alexa.NET.APL.Filters;
using Newtonsoft.Json;

namespace Alexa.NET.APL.JsonConverter
{
    public class ImageFilterListConverter : SingleOrListConverter<IImageFilter>
    {
        public ImageFilterListConverter() : this(false) { }

        public ImageFilterListConverter(bool alwaysOutputArray) : base(alwaysOutputArray) { }

        private readonly ImageFilterConverter _converter = new ImageFilterConverter();
        protected override JsonToken SingleToken => JsonToken.StartObject;

        protected override void ReadSingle(JsonReader reader, JsonSerializer serializer, List<IImageFilter> list)
        {
            var value = (IImageFilter)_converter.ReadJson(reader, typeof(IImageFilter), null, serializer);
            list.Add(value);
        }
    }
}