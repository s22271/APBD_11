using System.Collections.Generic;

namespace blazorserver.Data
{
    public interface IStudentService
    {
        public List<Student> GetStudents();
        public Student GetStudent(int id);
        public bool RemoveStudent(int id);
    }
}
