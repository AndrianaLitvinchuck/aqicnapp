using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Air.Models
{
    public class Time
    {

        [JsonPropertyName("s")]
        public string S { get; set; }

        [JsonPropertyName("tz")]
        public string Tz { get; set; }

        [JsonPropertyName("v")]
        public int V { get; set; }

        [JsonPropertyName("iso")]
        public DateTime Iso { get; set; }
    }
}