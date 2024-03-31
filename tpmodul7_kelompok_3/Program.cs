// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Text.Json.Serialization;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa mhs = new DataMahasiswa();

        var options = new JsonSerializerOptions
        {
            IncludeFields = true,
        };

        var mahasiswa = JsonSerializer.Deserialize<DataMahasiswa>(mhs.json);
        Console.WriteLine($"Nama {mahasiswa.name.Depan} {mahasiswa.name.Belakang} dengan NIM {mahasiswa.Nim}" + $" dari Fakultas {mahasiswa.Fakultas}");
    }
}