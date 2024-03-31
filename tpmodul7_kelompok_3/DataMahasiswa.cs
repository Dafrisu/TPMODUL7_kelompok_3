using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace tpmodul7_kelompok_3
{
    internal class DataMahasiswa
    {
        public class DataMahasiswa2
        {
            [JsonPropertyName("nim")]
            public int Nim { get; set; }
            [JsonPropertyName("nama")]
            public Nama name { get; set; }
            [JsonPropertyName("fakultas")]
            public string Fakultas { get; set; }
            public String json = "tp7_1_1302223154";
    {
        [JsonPropertyName("depan")]
            public string Depan { get; set; }

            [JsonPropertyName("belakang")]
            public string Belakang { get; set; }
        }

        public void ReadJSON()
        {
            Console.WriteLine("Input Json: " + json);
        }
    }
}