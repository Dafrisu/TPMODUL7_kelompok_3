using System;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.IO;
using System.Security.Cryptography.X509Certificates;


namespace tpmodul7_kelompok_3
{
    internal class KuliahMahasiswa_1302220150
    {
        public class KuliahMahasisiwa
        {
            [JsonPropertyName("courses")]
            public Courses[] matkul { get; set; }
            public string json2 = "tp7_2_1302220150.json";
            public void ReadJSON()
            {
                KuliahMahasisiwa listCourses = JsonSerializer.Deserialize<KuliahMahasisiwa>(json2);
                Console.WriteLine("Mata Kuliah Yang Diambil: ");
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine($"MK{i + 1} {listCourses.matkul[i].code} - {listCourses.matkul[i].name}");
                }
            }
        }
        public class Courses
        {
            [JsonPropertyName("code")]
            public string code { get; set; }
            [JsonPropertyName("name")]
            public string name { get; set; }
        }
    }
}
