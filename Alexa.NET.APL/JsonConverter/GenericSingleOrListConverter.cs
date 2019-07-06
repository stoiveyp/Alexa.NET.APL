using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Alexa.NET.APL.JsonConverter
{
    public class GenericSingleOrListConverter<T> : SingleOrListConverter<T>
    {
        protected override JsonToken SingleToken => JsonToken.StartObject;

        protected override void ReadSingle(JsonReader reader, JsonSerializer serializer, List<T> list)
        {
            var value = Activator.CreateInstance<T>();
            serializer.Populate(reader, value);
            list.Add(value);
        }
    }
}