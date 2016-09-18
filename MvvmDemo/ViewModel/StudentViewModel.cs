using System.Collections.ObjectModel;
using MvvmDemo.Model;

namespace MvvmDemo.ViewModel
{
    public class StudentViewModel
    {
        public ObservableCollection<Student> Students { get; set; }

        public void LoadStudents()
        {
            ObservableCollection<Student> students = new ObservableCollection<Student>
            {
                new Student {FirstName = "Mark", LastName = "Allain"},
                new Student {FirstName = "Allen", LastName = "Brown"},
                new Student {FirstName = "Linda", LastName = "Hamerski"}
            };

            Students = students;
        } 
    }
}
