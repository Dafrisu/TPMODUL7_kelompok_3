﻿using System;
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
    public String json = System.IO.File.ReadAllText(@"C:\Users\haika\OneDrive\Dokumen\KULIAH\SEMESTER 4\Konstruksi Perangkat Lunak\C#\TPMODUL7_kelompok_3\tp7_1_1302220150.json");
    public class Nama
    {
        [JsonPropertyName("depan")]
        public string Depan { get; set; }

        [JsonPropertyName("belakang")]
        public string Belakang { get; set; }
    }

    public void ReadJSON()
    {
        var options = new JsonSerializerOptions
        {
            IncludeFields = true,
        };
        var mahasiswa = JsonSerializer.Deserialize<DataMahasiswa>(json);
        Console.WriteLine($"Nama {mahasiswa.name.Depan} {mahasiswa.name.Belakang} dengan NIM {mahasiswa.Nim}" +
            $" dari Fakultas {mahasiswa.Fakultas}");
    }
}