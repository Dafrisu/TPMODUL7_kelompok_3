using System;
using System.IO;
using System.Text.Json.Serialization;
using System.Text.Json;
using tpmodul7_kelompok_3;
using Newtonsoft.Json;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bagian Darryl");
        DataMahasiswa_1302223154 mhs = new DataMahasiswa_1302223154();

        var options = new JsonSerializerOptions
        {
            IncludeFields = true,
        };

        var mahasiswa = JsonSerializer.Deserialize<DataMahasiswa_1302223154>(mhs.son);
        Console.WriteLine($"Nama {mahasiswa.name.Depan} {mahasiswa.name.Belakang} dengan NIM {mahasiswa.Nim}" + $" dari Fakultas {mahasiswa.Fakultas}");

        KuliahMahasiswa_1302223154 kuliah = new KuliahMahasiswa_1302223154();
        kuliah.ReadJSON();
        Console.WriteLine(" ");


        Console.WriteLine("Bagian dafa");
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
        Console.WriteLine(" ");


        Console.WriteLine("Bagian Mahesa - 1302220105");
        DataMahasiswa_1302220105.ReadJSON();
        KuliahMahasiswa_1302220105.ReadJSON();
        Console.WriteLine(" ");

        Console.WriteLine("Bagian Haikal");
        DataMahasiswa_1302220150 mhsHaikal = new DataMahasiswa_1302220150();
        KuliahMahasiswa_1302220150 kuliahHaikal = new KuliahMahasiswa_1302220150();
        mhsHaikal.ReadJson();
        kuliahHaikal.ReadJSON();
    }
}
