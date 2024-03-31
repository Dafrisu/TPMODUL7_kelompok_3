using System;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.IO;
using System.Security.Cryptography.X509Certificates;
public class KuliahMahasiswa
{
	[JsonPropertyName("courses")]
	public Courses[] matkul {get; set;}
    public String json2 = System.IO.File.ReadAllText(@"C:\Users\haika\OneDrive\Dokumen\KULIAH\SEMESTER 4\Konstruksi Perangkat Lunak\C#\TPMODUL7_kelompok_3\tp7_2_1302220150.json");
    public void ReadJSON()
    {
        KuliahMahasiswa listCourses = JsonSerializer.Deserialize<KuliahMahasiswa>(json2);
        Console.WriteLine("Mata Kuliah Yang Diambil: ");
        for (int i = 0;i<6; i++)
        {
            Console.WriteLine($"MK{i+1} {listCourses.matkul[i].code} - {listCourses.matkul[i].name}");
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
