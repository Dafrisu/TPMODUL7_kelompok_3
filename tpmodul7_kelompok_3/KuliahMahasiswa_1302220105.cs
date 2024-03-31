using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_3
{
    internal class KuliahMahasiswa_1302220105
    {
        public class Course
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class CourseData
        {
            public List<Course> courses { get; set; }
        }

        public static void ReadJSON()
        {
            string filePath = "tp7_2_1302220105.json";
            string jsonData = File.ReadAllText(filePath);

            try
            {
                CourseData courseData = JsonConvert.DeserializeObject<CourseData>(jsonData, new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Auto
                });

                if (courseData?.courses != null && courseData.courses.Count > 0)
                {
                    PrintCourses(courseData);
                }
                else
                {
                    Console.WriteLine("Error: No courses found in the JSON file.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private static void PrintCourses(CourseData courseData)
        {
            Console.WriteLine("Daftar mata kuliah yang diambil:");

            int i = 1;
            foreach (var course in courseData.courses)
            {
                Console.WriteLine($"MK {i} {course.code} - {course.name}");
                i++;
            }
        }
    }
}