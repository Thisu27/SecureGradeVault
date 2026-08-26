namespace StudentRecordManager.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public double GPA { get; set; }
    }
}
