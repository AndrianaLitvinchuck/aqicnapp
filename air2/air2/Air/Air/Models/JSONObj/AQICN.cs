using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Air.Models
{
    public class AQICN
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("data")]
        public Data Data { get; set; }


        //выборка данных по API
        public AQICN GetData(string url)
        {
            try
            {

                WebRequest httpRequest = HttpWebRequest.Create(url);
                httpRequest.ContentType = "application/json; charset=utf-8";
                httpRequest.Method = "GET";

                StreamReader responseReader = new StreamReader(httpRequest.GetResponse().GetResponseStream());
                string responseData = responseReader.ReadToEnd();

                AQICN obj = JsonConvert.DeserializeObject<AQICN>(responseData);
                responseReader.Close();

                return obj;

            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<AQICN> GetDataAsync(string url)
        {
            return await Task.Run(() => GetData(url));
        }
    }
}
