namespace Exercise3
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string Academy { get; set; }
        public string Group { get; set; }

        public Student(string firstName, string lastName, string academy, string group) {
            FirstName = firstName;
            LastName = lastName;
            Academy = academy;
            Group = group;
        }

        public string GetInfo()
        {
            return $"{FullName} - \"{Academy}\" [{Group}]";
        }
    }
}
