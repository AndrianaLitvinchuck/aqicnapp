using System.Text.Json.Serialization;

namespace Air.Models
{
    public class Forecast
    {
        [JsonPropertyName("daily")]
        public Daily Daily { get; set; }
    }
}