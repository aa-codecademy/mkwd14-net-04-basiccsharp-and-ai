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

        public void SetGrade(Subject subject, int grade)
        {
            if (!Subjects.Any(x => x.Id == subject.Id))
            {
                throw new Exception($"Student is not enrolled in the subject: {subject.Name}");
            }

            if (Grades.Any(x => x.Key.Id == subject.Id))
            {
                throw new Exception($"The student already has a grade for the subject: {subject.Name}");
            }

            if(grade < 5 || grade > 10)
            {
                throw new Exception($"Grade must be between 5 and 10. Provided grade: {grade}");
            }

            Grades[subject] = grade;
        }
    }
}
