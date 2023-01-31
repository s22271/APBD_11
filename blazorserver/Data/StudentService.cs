using System.Collections.Generic;
using System.Linq;

namespace blazorserver.Data
{
    public class StudentService : IStudentService
    {
        public List<Student> Students { get; set; }

        public StudentService()
        {
            Students = new List<Student>
            {
                new Student
                {
                    ID = 1,
                    FirstName = "Maciej",
                    LastName = "Kot",
                    Birthdate = new System.DateTime(2022, 1, 1),
                    Avatar = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/cute-cat-photos-1593441022.jpg?crop=0.670xw:1.00xh;0.167xw,0&resize=640:*",
                    Studies = "Sleeping"
                },
                new Student
                {
                    ID = 2,
                    FirstName = "Paweł",
                    LastName = "Kot",
                    Birthdate = new System.DateTime(1990, 1, 1),
                    Avatar = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQzSIXzG8jusOJpncDLGKqYqF1GqX1EOpew6FuVvnKX&s",
                    Studies = "Eating"
                },
                new Student
                {
                    ID = 3,
                    FirstName = "Andrzej",
                    LastName = "Kot",
                    Birthdate = new System.DateTime(1920, 1, 1),
                    Avatar = "https://media.istockphoto.com/id/1267021092/photo/funny-winking-kitten.jpg?s=612x612&w=0&k=20&c=9PoFYkqKZ30F_ubxX90_azwsR22ENwrFnOjxV0RaoTo=",
                    Studies = "Playing"
                }
            };
        }

        public List<Student> GetStudents()
        {
            return Students;
        }

        public Student GetStudent(int id)
        {
            return Students.FirstOrDefault(e => e.ID == id);
        }

        public bool RemoveStudent(int id)
        {
            return Students.Remove(Students.FirstOrDefault(e => e.ID == id));
        }
    }
}
