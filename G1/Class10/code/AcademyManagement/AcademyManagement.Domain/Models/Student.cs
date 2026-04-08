using AcademyManagement.Domain.Enums;

namespace AcademyManagement.Domain.Models;

public class Student : User
{
    public string CurrentSubject { get; set; }
    public Dictionary<string, int> SubjectGrade { get; set; }

    public Student(string username, string password) 
        : base(username, password)
    {
        Role = Role.Student;
    }

    public Student(string fname, string lName, string username, string password, int age) 
        : base(fname, lName, username, password, age)
    {
        Role = Role.Student;
    }
}
