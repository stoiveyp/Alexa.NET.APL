using System.Collections.Generic;
using System.Text;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.JsonConverter
{
    public class StyleValueListConverter : SingleOrListConverter<StyleValue>
    {
        protected override JsonToken SingleToken => JsonToken.StartObject;
        protected override void ReadSingle(JsonReader reader, JsonSerializer serializer, List<StyleValue> list)
        {
            var value = new StyleValue();
            serializer.Populate(reader, value);
            list.Add(value);
        }
    }
}
