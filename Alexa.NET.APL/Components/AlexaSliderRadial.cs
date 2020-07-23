using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class AlexaSliderRadial : AlexaSliderBase
    {
        public override string Type => nameof(AlexaSliderRadial);

        [JsonProperty("useDefaultSliderExpandTransition", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> UseDefaultSliderExpandTransition { get; set; }
    }
}