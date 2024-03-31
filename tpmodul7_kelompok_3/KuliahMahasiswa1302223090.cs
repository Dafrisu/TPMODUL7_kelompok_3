using Newtonsoft.Json;
using System;
using System.IO;

namespace tpmodul7_kelompok_3
{
    internal class KuliahMahasiswa1302223090
    {
        public class Course
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class CourseData
        {
            public Course[] courses { get; set; }
        }

        public static void ReadJSON()
        {
            string filePath = "tp7_2_1302223090.json";
            string jsonData = File.ReadAllText(filePath);

            try
            {
                CourseData courseData = JsonConvert.DeserializeObject<CourseData>(jsonData);

                if (courseData?.courses != null && courseData.courses.Length > 0)
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
                Console.WriteLine($"Mata Kuliah {i} {course.code} - {course.name}");
                i++;
            }
        }
    }
}