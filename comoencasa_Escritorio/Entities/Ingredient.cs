using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace comoencasa_Escritorio.Entities
{
    public class Ingredient
    {
        [JsonProperty("id")]
        public long id {  get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("fromMonth")]
        public int fromMonth { get; set; }
        [JsonProperty("toMonth")]
        public int toMonth { get; set; }
        [JsonProperty("type")]
        public string type { get; set; }
    }
}
