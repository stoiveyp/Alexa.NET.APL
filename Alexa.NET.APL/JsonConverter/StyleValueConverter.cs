using System;
using System.Collections.Generic;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.JsonConverter
{
    public class StyleValueConverter:Newtonsoft.Json.JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value != null && value is StyleValue styleValue)
            {
                var dictionary = new Dictionary<string, string>(styleValue);
                if (dictionary.ContainsKey("when"))
                {
                    dictionary.Remove("when");
                }
                dictionary.Add("when",styleValue.When);

                serializer.Serialize(writer,dictionary);
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var baseDictionary = new Dictionary<string, string>();
            serializer.Populate(reader,baseDictionary);
            var styleValue = new StyleValue(baseDictionary);
            if (styleValue.ContainsKey("when"))
            {
                styleValue.When = styleValue["when"];
                styleValue.Remove("when");
            }

            return styleValue;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(StyleValue);
        }
    }
}