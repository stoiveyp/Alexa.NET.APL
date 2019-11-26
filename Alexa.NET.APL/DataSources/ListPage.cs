using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alexa.NET.APL.DataSources
{
    public class ListPage
    {
        public ListPage()
        {
            ListItems = new List<object>();
        }

        [JsonProperty("listItems")]
        public List<object> ListItems { get; set; }
    }
}