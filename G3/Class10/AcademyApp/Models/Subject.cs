namespace Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int NumberOfClasses { get; set; }
        public Academy Academy { get; set; }

        public Subject(int id, string name, string description, int numberOfClasses, Academy academy)
        {
            Id = id;
            Name = name;
            Description = description;
            NumberOfClasses = numberOfClasses;
            Academy = academy;
        }
    }
}
