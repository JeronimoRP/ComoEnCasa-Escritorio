using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace comoencasa_Escritorio.Entities
{
    public class User
    {
        [JsonProperty("id")]
        public long id { get; set; }
        [JsonProperty("email")]
        public string email {  get; set; }
        [JsonProperty("password")]
        public string password { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
    }
}
