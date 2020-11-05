using System;
using System.Text.Json.Serialization;

namespace Air.Models
{
    public class Debug
    {
        [JsonPropertyName("sync")]
        public DateTime Sync { get; set; }
    }
}