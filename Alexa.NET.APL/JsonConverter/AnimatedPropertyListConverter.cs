using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.APL.Commands;
using Newtonsoft.Json;

namespace Alexa.NET.APL.JsonConverter
{
    public class AnimatedPropertyListConverter : SingleOrListConverter<AnimatedProperty>
    {
        private readonly AnimatedPropertyConverter _converter = new AnimatedPropertyConverter();
        protected override JsonToken SingleToken => JsonToken.StartObject;
        protected override void ReadSingle(JsonReader reader, JsonSerializer serializer, List<AnimatedProperty> list)
        {
            var value = (AnimatedProperty)_converter.ReadJson(reader, typeof(AnimatedProperty), null, serializer);
            list.Add(value);
        }
    }
}
