using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_3
{
    internal class DataMahasiswa_1302220140
    {
        public class DataMahasiswa
        {
            [JsonPropertyName("nim")]
            public int Nim { get; set; }
            [JsonPropertyName("nama")]
            public Nama name { get; set; }
            [JsonPropertyName("fakultas")]
            public string Fakultas { get; set; }
            public String json = System.IO.File.ReadAllText(@"tp7_1_1302220140.json");
            public class Nama
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

            public DataMahasiswa()
            {

            }

        }
    }
}
