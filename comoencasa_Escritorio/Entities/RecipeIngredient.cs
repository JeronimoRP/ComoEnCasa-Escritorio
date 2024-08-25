using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comoencasa_Escritorio.Entities
{
    public class RecipeIngredient
    {
        [JsonProperty("ingredient")]
        public string ingredient { get; set; }
        [JsonProperty("quantity")]
        public string quantity { get; set; }
    }
}
