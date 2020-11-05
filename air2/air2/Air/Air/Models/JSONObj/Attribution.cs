using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Air.Models
{
    public class Attribution
    {
        [JsonPropertyName("url")]
        public string Url { get; set; } 

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
