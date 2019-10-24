using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.Response.APL;
using Newtonsoft.Json.Linq;

namespace Alexa.NET.APL.JsonConverter
{
    public class APLDocumentConverter:JsonConverter<APLDocumentBase>
    {
        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, APLDocumentBase value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override APLDocumentBase ReadJson(JsonReader reader, Type objectType, APLDocumentBase existingValue, bool hasExistingValue,
            JsonSerializer serializer)
        {
            var jObject = JObject.Load(reader);
            var documentType = jObject.Value<string>("type");
            if (documentType == "APL")
            {
                var apl = new APLDocument();
                serializer.Populate(jObject.CreateReader(), apl);
                return apl;
            }

            if(documentType == "APLT")
            {
                var aplt = new APLTDocument();
                serializer.Populate(jObject.CreateReader(), aplt);
                return aplt;
            }

            throw new InvalidOperationException($"Unknown APL Document type {documentType}");
        }
    }
}
