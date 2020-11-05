using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Air.Models.JSONObj
{
    public class Value
    {
        [JsonPropertyName("v")]
        public double V { get; set; }
    }
}
