using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alexa.NET.APL.JsonConverter
{
    public class APLPageMoveConverter : SingleOrListConverter<APLPageMoveHandler>
    {
        public APLPageMoveConverter() : this(false) { }

        public APLPageMoveConverter(bool alwaysOutputArray) : base(alwaysOutputArray) { }

        protected override JsonToken SingleToken => JsonToken.StartObject;

        protected override void ReadSingle(JsonReader reader, JsonSerializer serializer, List<APLPageMoveHandler> list)
        {
            var value = serializer.Deserialize<APLPageMoveHandler>(reader);
            list.Add(value);
        }
    }
}