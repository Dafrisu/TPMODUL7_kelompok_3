using System;
using System.IO;
using System.Text.Json.Serialization;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa mhs = new DataMahasiswa();
        DataMahasiswa1 course = new DataMahasiswa1();
        mhs.ReadJSON();
        course.ReadJSON();


    }


}