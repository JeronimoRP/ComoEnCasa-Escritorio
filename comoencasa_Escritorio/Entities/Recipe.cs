using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace comoencasa_Escritorio.Entities
{
    public class Recipe
    {
        [JsonProperty("id")]
        public long id {  get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("description")]
        public string description { get; set; }
        [JsonProperty("photo")]
        public string photo { get; set; }
        [JsonProperty("ingredientsList")]
        public List<RecipeIngredient> ingredientsList { get; set; }
    }
}
