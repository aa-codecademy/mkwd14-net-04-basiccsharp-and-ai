namespace Exercise1
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        //public string FullName
        //{
        //    get {
        //        return $"{FirstName} {LastName}";
        //    }
        //}
        public string FullName => $"{FirstName} {LastName}";

        public Human() { } // Default constructor

        public Human(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public Human(string firstName)
        {
            FirstName = firstName;
        }

        public string GetPersonStats()
        {
            return $"Name: {FirstName} {LastName}, Age: {Age}";
        }

        //public void PrintPersonStats()
        //{
        //    Console.WriteLine($"Name: {FirstName} {LastName}, Age: {Age}");
        //}
    }
}
