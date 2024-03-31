using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;


public class DataMahasiswa
{
    [JsonPropertyName("nim")]
    public int Nim { get; set; }
    [JsonPropertyName("nama")]
    public Nama name { get; set; }
    [JsonPropertyName("fakultas")]
    public string Fakultas { get; set; }
    public String json = System.IO.File.ReadAllText(@"C:\Users\ASUS\Documents\KPL\TP_MOD7_1302223154_DarrylRambi\TPMODUL7_kelompok_3\tpmodul7_kelompok_3\tp7_1_1302223154.json");

    public class Nama
    {
        [JsonPropertyName("depan")]
        public string Depan { get; set; }

        [JsonPropertyName("belakang")]
        public string Belakang { get; set; }
    }

    public void ReadJSON()
    {
        Console.WriteLine(json);
    }
}