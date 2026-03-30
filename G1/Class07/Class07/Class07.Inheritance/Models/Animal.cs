namespace Class07.Inheritance.Models;

public class Animal
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }

    public Animal()
    {
        Console.WriteLine("A new instance of an animal has been created!This is the Animal empty constructor.");
        Thread.Sleep(2000);
    }

    public Animal(string type)
    {
        Type = type;
        Console.WriteLine("This is the type constructor of an Animal!");
        Thread.Sleep(2000);
    }

    public Animal(int id, string name, string type)
    {
        Id = id;
        Name = name;
        Type = type;
    }

    public virtual void Eat()
    {
        Console.WriteLine($"The {Type} animal named {Name} is eating!");
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Id: {Id}, Animal: {Type}, Name: {Name}");
    }
}
