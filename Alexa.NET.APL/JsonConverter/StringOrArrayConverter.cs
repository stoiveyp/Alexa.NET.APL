using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alexa.NET.APL.JsonConverter
{
    public class StringOrArrayConverter : SingleOrListConverter<string>
    {
        protected override JsonToken SingleToken => JsonToken.String;
        protected override void ReadSingle(JsonReader reader, JsonSerializer serializer, List<string> list)
        {
            list.Add(reader.Value.ToString());
        }
    }
}