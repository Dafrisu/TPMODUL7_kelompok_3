using System;
using System.IO;
using System.Text.Json.Serialization;
using System.Text.Json;
using tpmodul7_kelompok_3;

class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa mhs = new DataMahasiswa();
        mhs.ReadJSON();

        var options = new JsonSerializerOptions
        {
            IncludeFields = true,
        };
        var mahasiswa = JsonSerializer.Deserialize<DataMahasiswa>(mhs.json);
        Console.WriteLine($"Nim: {mahasiswa.Nim}");
        Console.WriteLine($"nama: {mahasiswa.name.Depan} {mahasiswa.name.Belakang}");
        Console.WriteLine($"Fakultas: {mahasiswa.Fakultas}");
        Console.WriteLine($"Nama {mahasiswa.name.Depan} {mahasiswa.name.Belakang} dengan NIM {mahasiswa.Nim}" + $" dari Fakultas {mahasiswa.Fakultas}");

        KuliahMahasiswa course = new KuliahMahasiswa();
        course.ReadJSON();

        Console.WriteLine("Bagian Mahesa - 1302220105");
        DataMahasiswa_1302220105.ReadJSON();
        KuliahMahasiswa_1302220105.ReadJSON();
        Console.WriteLine(" ");
    }
}
