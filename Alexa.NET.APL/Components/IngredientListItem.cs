using System.Collections.Generic;
using Alexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class IngredientListItem
    {
        [JsonProperty("ingredientsContentText",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> IngredientsContentText { get; set; }

        [JsonProperty("ingredientsPrimaryAction",NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> IngredientsPrimaryAction { get; set; }
    }
}