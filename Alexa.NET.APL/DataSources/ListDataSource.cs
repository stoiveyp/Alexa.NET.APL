using System;
using System.Text;
using Alexa.NET.APL.Components;
using Newtonsoft.Json;

namespace Alexa.NET.APL.DataSources
{
    public class ListDataSource : APLDataSource
    {
        public override string Type => "list";

        [JsonProperty("listPage")]
        public ListPage ListPage { get; }

        [JsonProperty("listId")]
        public string ListId { get; set; }

        [JsonProperty("totalNumberOfItems")]
        public int TotalNumberOfItems { get; set; }

        public ListDataSource()
        {
            ListPage = new ListPage();
        }
    }
}
