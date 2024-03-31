using System;
using System.IO;
using Newtonsoft.Json;


namespace tpmodul7_kelompok_3
{
    internal class DataMahasiswa_1302220105
    {
        public class namaData
        {
            public string depan;
            public string belakang;
            
            public namaData(string depan, string belakang)
            {
                this.depan = depan;
                this.belakang = belakang;
            }
        }
        public class MahasiswaData
        {
            public namaData nama;
            public int nim;
            public string fakultas;

            public MahasiswaData(namaData nama, int nim,string fakultas)
            {
                this.nama = nama;
                this.nim = nim;
                this.fakultas = fakultas;
            }
            public void PrintData()
            {
                Console.WriteLine($"Nama {nama.depan} {nama.belakang} dengan nim {nim} dari fakultas {fakultas}");
            }
        }
        public static void ReadJSON()
        {
            string fileName = "tp7_1_1302220105.json";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            try
            {
                string jsonData = File.ReadAllText(filePath);
                MahasiswaData mahasiswaData = JsonConvert.DeserializeObject<MahasiswaData>(jsonData, new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Auto
                });

                mahasiswaData.PrintData();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading JSON file: {ex.Message}");
            }
        }
    }
}
