using AcademyManagement.Domain.Enums;

namespace AcademyManagement.Domain.Models;

public class Trainer : User
{
    public Trainer(string fName, string lName, string username, string password, int age)
        : base(fName, lName, username, password, age)
    {
        Role = Role.Trainer;
    }

    public Trainer(string username, string password)
        : base(username, password)
    {
        Role = Role.Trainer;
    }
}
