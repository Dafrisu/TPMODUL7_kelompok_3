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
    public String json = System.IO.File.ReadAllText(@"C:\Users\USER\tp7_1_1302220140.json");
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