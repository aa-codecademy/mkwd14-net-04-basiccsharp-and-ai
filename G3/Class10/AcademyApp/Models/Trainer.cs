namespace Models
{
    public class Trainer : User
    {
        public List<Subject> Subjects { get; set; } = new List<Subject>();

        public Trainer(int id, string firstName, string lastName, string username, string password)
            : base(id, firstName, lastName, username, password, Role.Trainer)
        {
        }

        public Trainer(int id, string firstName, string lastName, string username, string password, List<Subject> subjects)
            : base(id, firstName, lastName, username, password, Role.Trainer)
        {
            Subjects = subjects;
        }
    }
}
