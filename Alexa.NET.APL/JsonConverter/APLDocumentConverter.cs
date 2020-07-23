using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.Response.APL;
using Newtonsoft.Json.Linq;

namespace Alexa.NET.APL.JsonConverter
{
    public class APLDocumentConverter:JsonConverter<APLDocumentReference>
    {
        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, APLDocumentReference value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override APLDocumentReference ReadJson(JsonReader reader, Type objectType, APLDocumentReference existingValue, bool hasExistingValue,
            JsonSerializer serializer)
        {
            var jObject = JObject.Load(reader);
            var documentType = jObject.Value<string>("type");

            switch (documentType.ToUpper())
            {
                case "APL":
                    var apl = new APLDocument();
                    serializer.Populate(jObject.CreateReader(), apl);
                    return apl;
                case "APLT":
                    var aplt = new APLTDocument();
                    serializer.Populate(jObject.CreateReader(), aplt);
                    return aplt;
                case "LINK":
                    var link = new APLDocumentLink();
                    serializer.Populate(jObject.CreateReader(), link);
                    return link;
            }

            throw new InvalidOperationException($"Unknown APL Document type {documentType}");
        }
    }
}
