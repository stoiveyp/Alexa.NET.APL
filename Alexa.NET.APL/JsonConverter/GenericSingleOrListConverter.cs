using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Alexa.NET.APL.JsonConverter
{
    public class GenericSingleOrListConverter<T> : SingleOrListConverter<T>
    {
        public GenericSingleOrListConverter() : base() { }

        public GenericSingleOrListConverter(bool alwaysOutputArray):base(alwaysOutputArray)
        {
            
        }

        protected override JsonToken SingleToken => JsonToken.StartObject;

        protected override void ReadSingle(JsonReader reader, JsonSerializer serializer, List<T> list)
        {
            if (typeof(T) == typeof(object))
            {
                list.Add((T)serializer.Deserialize(reader));
            }
            else
            {
                var value = Activator.CreateInstance<T>();
                serializer.Populate(reader, value);
                list.Add(value);
            }
        }
    }
}