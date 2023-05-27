using Newtonsoft.Json;

namespace Alexa.NET.APL
{
    public class VisibleComponentTags
    {
        [JsonProperty("focused",NullValueHandling = NullValueHandling.Ignore)]
        public bool? Focused { get; set; }

        [JsonProperty("clickable",NullValueHandling = NullValueHandling.Ignore)]
        public bool? Clickable { get; set; }

        [JsonProperty("checked",NullValueHandling = NullValueHandling.Ignore)]
        public bool? Checked { get; set; }

        [JsonProperty("disabled",NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disabled { get; set; }

        [JsonProperty("spoken",NullValueHandling = NullValueHandling.Ignore)]
        public bool? Spoken { get; set; }

        [JsonProperty("ordinal",NullValueHandling = NullValueHandling.Ignore)]
        public int? Ordinal { get; set; }

        [JsonProperty("list",NullValueHandling = NullValueHandling.Ignore)]
        public VisibleComponentListTag List { get; set; }

        [JsonProperty("list_item",NullValueHandling = NullValueHandling.Ignore)]
        public VisibleComponentListItemTag ListItem { get; set; }

        [JsonProperty("media",NullValueHandling = NullValueHandling.Ignore)]
        public VisibleComponentMediaTag Media { get; set; }

        [JsonProperty("pager",NullValueHandling = NullValueHandling.Ignore)]
        public VisibleComponentPagerTag Pager { get; set; }

        [JsonProperty("scrollable",NullValueHandling = NullValueHandling.Ignore)]
        public VisibleComponentScrollableTag Scrollable { get; set; }

        [JsonProperty("viewport",NullValueHandling = NullValueHandling.Ignore)]
        public APLViewport Viewport { get; set; }
    }
}