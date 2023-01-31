using System;

namespace blazorserver.Data
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Avatar { get; set; }
        public DateTime Birthdate { get; set; }
        public string Studies { get; set; }
    }
}
