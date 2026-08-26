using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using StudentRecordManager.Models;

namespace StudentRecordManager
{
    public static class DataStore
    {
        private static readonly string FilePath = "students.json";

        public static void SaveStudents(List<Student> students)
        {
            string json = JsonSerializer.Serialize(
                students,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                }
            );

            File.WriteAllText(FilePath, json);
        }

        public static List<Student> LoadStudents()
        {
            if (!File.Exists(FilePath))
            {
                return new List<Student>();
            }

            string json = File.ReadAllText(FilePath);

            return JsonSerializer.Deserialize<List<Student>>(json)
                   ?? new List<Student>();
        }
    }
}
