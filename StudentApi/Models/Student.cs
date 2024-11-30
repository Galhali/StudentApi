using StudentApi.Enums;

namespace StudentApi.Models
{
    public class Student
    {
        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public int IndexNumber { get; private set; }
        public Gender Gender { get; private set; }

        public Student(
            Guid id,
            string firstName,
            string lastName,
            int age,
            int indexNumber,
            Gender gender)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            IndexNumber = indexNumber;
            Gender = gender;
        }

        public Student() { }
    }
}
