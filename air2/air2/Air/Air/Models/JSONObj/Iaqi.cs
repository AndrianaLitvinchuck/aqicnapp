using Air.Models.JSONObj;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Air.Models
{
    public class Iaqi
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [JsonPropertyName("co")]
        public Co co { get; set; }

        [JsonPropertyName("h")]
        public H h { get; set; }

        [JsonPropertyName("no2")]
        public No2 no2 { get; set; }

        [JsonPropertyName("o3")]
        public O3 o3 { get; set; }

        [JsonPropertyName("p")]
        public P p { get; set; }

        [JsonPropertyName("pm10")]
        public Pm10 pm10 { get; set; }

        [JsonPropertyName("pm25")]
        public Pm25 pm25 { get; set; }

        [JsonPropertyName("so2")]
        public So2 so2 { get; set; }

        [JsonPropertyName("t")]
        public T t { get; set; }

        [JsonPropertyName("w")]
        public W w { get; set; }


        public class Co : Value {}
        public class H : Value {}
        public class No2 : Value {}
        public class O3 : Value {}
        public class P : Value {}
        public class Pm10 : Value {}
        public class Pm25 : Value {}
        public class So2 : Value {}
        public class T : Value {}
        public class W : Value {}      

    }
}