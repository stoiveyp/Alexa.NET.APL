using Alexa.NET.APL;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.Response.APL
{
    [JsonConverter(typeof(DocumentBackgroundColorConverter))]
    public class DocumentBackgroundColor
    {
        public DocumentBackgroundColor(string color)
        {
            Color = color;
        }

        public DocumentBackgroundColor(APLGradient gradient)
        {
            Gradient = gradient;
        }

        public string Color { get; set; }
        public APLGradient Gradient { get; set; }

        public static implicit operator DocumentBackgroundColor(string color)
        {
            return new DocumentBackgroundColor(color);
        }

        public static implicit operator DocumentBackgroundColor(APLGradient gradient)
        {
            return new DocumentBackgroundColor(gradient);
        }
    }
}