using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tpmodul7_kelompok_3
{
    internal class DataMahasiswa1302223090
    {
        public class NamaData
        {
            public string depan { get; set; }
            public string belakang { get; set; }
        }

        public class MahasiswaData
        {
            public NamaData nama { get; set; }
            public int nim { get; set; }
            public string fakultas { get; set; }

            public void PrintData()
            {
                Console.WriteLine($"Nama {nama.depan} {nama.belakang} dengan nim {nim} dari fakultas {fakultas}");
            }
        }

        public static void ReadJSON()
        {
            string fileName = "tp7_1_1302223090.json";
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