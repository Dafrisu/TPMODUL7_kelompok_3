using System.Text.Json.Serialization;
using System.IO;
using System;
using System.Text.Json;


namespace tpmodul7_kelompok_3
{
    internal class KuliahMahasiswa_1302220140
    {
        public class DataMahasiswa1
        {
            [JsonPropertyName("courses")]
            public Courses[] matkul { get; set; }
            public String json2 = System.IO.File.ReadAllText(@"\tp7_2_1302220140.json");
            public void ReadJSON()
            {
                string json2 = this.json2;
                DataMahasiswa1 listCourses = JsonSerializer.Deserialize<DataMahasiswa1>(json2);
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