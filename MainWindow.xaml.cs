using System.Windows;

namespace StudentRecordManager
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var students = new System.Collections.Generic.List<StudentRecordManager.Models.Student>
            {
                new StudentRecordManager.Models.Student
                {
                    StudentId = 1,
                    Name = "Thisari Nethmini",
                    Email = "thisari@ecu.edu.au",
                    GPA = 3.8
                },
                new StudentRecordManager.Models.Student
                {
                    StudentId = 2,
                    Name = "Alex Chen",
                    Email = "alex@ecu.edu.au",
                    GPA = 3.5
                }
            };

            DataStore.SaveStudents(students);

            var loaded = DataStore.LoadStudents();

            MessageBox.Show(
                $"Saved and reloaded {loaded.Count} students.\n" +
                $"First: {loaded[0].Name}, GPA: {loaded[0].GPA}"
            );
        }
    }
}