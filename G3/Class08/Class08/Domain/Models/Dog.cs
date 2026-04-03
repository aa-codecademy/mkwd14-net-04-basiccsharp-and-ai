namespace Domain.Models
{
    // A *primary constructor* is a C# 12 feature that
    // lets you define constructor parameters directly
    // on the class declaration line,
    // instead of writing a separate constructor body
    public class Dog(string name, int age)
    {
        public string Name { get; set; } = name;
        public int Age { get; set; } = age;

        public override string ToString()
        {
            return $"Name: {Name}. Age: {Age}.";
        }
    }
}
