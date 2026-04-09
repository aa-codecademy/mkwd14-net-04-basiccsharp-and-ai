namespace Models
{
    public static class StaticDatabase
    {
        public static List<Subject> Subjects { get; set; } = new List<Subject>()
        {
            new Subject(1, "C# Fundamentals", "Introduction to C# programming language and .NET framework", 20, Academy.WebDevelopment),
            new Subject(2, "ASP.NET Core MVC", "Building web applications using ASP.NET Core MVC pattern", 25, Academy.WebDevelopment),
            new Subject(3, "Manual Testing", "Fundamentals of manual testing and test case design", 18, Academy.Qa),
            new Subject(4, "Test Automation with Selenium", "Automated testing using Selenium WebDriver and C#", 22, Academy.Qa),
            new Subject(5, "UI/UX Design Principles", "User interface and user experience design fundamentals", 15, Academy.Design),
            new Subject(6, "Figma Design Workshop", "Practical design skills using Figma tool", 12, Academy.Design),
            new Subject(7, "Python for Data Science", "Introduction to Python programming for data analysis", 24, Academy.DataScience),
            new Subject(8, "Machine Learning Basics", "Fundamentals of machine learning algorithms and applications", 28, Academy.DataScience),
            new Subject(9, "JavaScript & React", "Modern front-end development with JavaScript and React framework", 26, Academy.WebDevelopment),
            new Subject(10, "SQL & Database Design", "Relational database concepts and SQL query optimization", 16, Academy.DataScience)
        };

        public static List<User> Users { get; set; } = new List<User>()
        {
            // Admin
            new Admin(1, "John", "Smith", "admin", "admin123"),

            // Trainers from different academies
            new Trainer(2, "Sarah", "Johnson", "sarah.trainer", "trainer123", new List<Subject> { Subjects[0], Subjects[1] }), // WebDevelopment
            new Trainer(3, "Michael", "Chen", "michael.trainer", "trainer123", new List<Subject> { Subjects[2], Subjects[3] }), // QA

            // Students from different academies
            new Student(4, "Emma", "Williams", "emma.student", "student123", Subjects.Where(x => x.Academy == Academy.WebDevelopment).ToList()), // WebDevelopment & DataScience
            new Student(5, "David", "Martinez", "david.student", "student123", Subjects.Where(x => x.Academy == Academy.Qa).ToList()), // Qa
            new Student(6, "Sophia", "Anderson", "sophia.student", "student123", Subjects.Where(x => x.Academy == Academy.DataScience).ToList()) // DataScience
        };

        //public static List<Student> Students { get; set; } = new List<Student>();
        //public static List<Trainer> Teachers { get; set; } = new List<Trainer>();
        //public static List<Admin> Admins { get; set; } = new List<Admin>();
    }
}
