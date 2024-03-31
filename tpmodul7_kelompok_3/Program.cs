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
        KuliahMahasiswa kuliah = new KuliahMahasiswa();
        mhs.ReadJSON();

        
        kuliah.ReadJSON();
    }
}