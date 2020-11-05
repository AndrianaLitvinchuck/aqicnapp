using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Air.Models
{
    public class Daily
    {
        [JsonPropertyName("o3")]
        public List<O32> O3 { get; set; }

        [JsonPropertyName("pm10")]
        public List<Pm102> Pm10 { get; set; }

        [JsonPropertyName("pm25")]
        public List<Pm252> Pm25 { get; set; }

        [JsonPropertyName("uvi")]
        public List<Uvi> UVI { get; set; }


        public class O32: Mark {}
        public class Pm102 : Mark { }
        public class Pm252 : Mark { }
        public class Uvi : Mark { }

    }
}