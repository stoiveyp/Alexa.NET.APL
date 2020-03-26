using System.Collections.Generic;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class AlexaLists : AlexaImageListBase
    {
        public override string Type => nameof(AlexaLists);

        [JsonProperty("defaultImageSource",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> DefaultImageSource { get; set; }

        [JsonProperty("emptyPrimaryText",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> EmptyPrimaryText { get; set; }

        [JsonProperty("emptySecondaryText",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> EmptySecondaryText { get; set; }

        [JsonProperty("footerHintText",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> FooterHintText { get; set; }

        [JsonProperty("hideDivider",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> HideDivider { get; set; }

        [JsonProperty("listImagePrimacy",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> ListImagePrimacy { get; set; }

        [JsonProperty("listItems",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<IList<AlexaListItem>> ListItems { get; set; }

        [JsonProperty("touchForward",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> TouchForward { get; set; }
    }
}