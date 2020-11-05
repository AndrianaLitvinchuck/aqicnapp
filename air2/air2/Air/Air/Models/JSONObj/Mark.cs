using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Air.Models
{
    // показатель
    public abstract class Mark
    {
        public string Id { get; set; }

        [JsonPropertyName("avg")]
        public int Avg { get; set; }

        [JsonPropertyName("day")]
        public string Day { get; set; }

        [JsonPropertyName("max")]
        public int Max { get; set; }

        [JsonPropertyName("min")]
        public int Min { get; set; }
    }
}
