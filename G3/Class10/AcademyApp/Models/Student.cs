namespace Models
{
    public class Student : User
    {
        public List<Subject> Subjects { get; set; } = new List<Subject>();
        public Dictionary<Subject, int> Grades { get; set; } = new Dictionary<Subject, int>();

        public Student(int id, string firstName, string lastName, string username, string password)
            : base(id, firstName, lastName, username, password, Role.Student)
        {
        }

        public Student(int id, string firstName, string lastName, string username, string password, List<Subject> subjects)
            : base(id, firstName, lastName, username, password, Role.Student)
        {
            Subjects = subjects;
        }
    }
}
