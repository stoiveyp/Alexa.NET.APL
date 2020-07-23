using Alexa.NET.APL.JsonConverter;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public abstract class AlexaProgressBarBase:APLComponent
    { 
        [JsonProperty("bufferValue",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> BufferValue { get; set; }

        [JsonProperty("isLoading",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> IsLoading { get; set; }

        [JsonProperty("progressBarType",NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLValueEnumConverter<ProgressBarType>))]
        public APLValue<ProgressBarType?> ProgressBarType { get; set; }

        [JsonProperty("progressFillColor",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ProgressFillColor { get; set; }

        [JsonProperty("progressValue",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> ProgressValue { get; set; }

        [JsonProperty("theme", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Theme { get; set; }

        [JsonProperty("totalValue",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> TotalValue { get; set; }
    }
}