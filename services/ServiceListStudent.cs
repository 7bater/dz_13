using System.Collections.Generic;
using dz_13.models;

namespace dz_13.services
{
    public class ServiceListStudent
    {
        public List<Student> Students { get; set; }

        public ServiceListStudent(List<Student> students)
        {
            Students = students;
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
    }
}