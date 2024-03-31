using System;
using System.IO;
using System.Text.Json.Serialization;
using System.Text.Json;
using tpmodul7_kelompok_3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bagian Fersya - 1302223090");
        DataMahasiswa1302223090.ReadJSON();
        KuliahMahasiswa1302223090.ReadJSON();
        Console.WriteLine(" ");
    }
}