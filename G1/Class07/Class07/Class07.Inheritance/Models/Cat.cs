namespace Class07.Inheritance.Models;

public class Cat : Animal
{
    public string Lazyness { get; set; }

    public Cat() : base("Cat")
    {
        Console.WriteLine("A new instance of cat is created using the partent constructor that requires a string!");
        Thread.Sleep(2000);
    }

    public void Meow()
    {
        Console.WriteLine("Meow, Meow!");
    }

    public override void Eat()
    {
        Console.WriteLine("You don't tell a cat when to eat. A CAT EATS WHEN IT WANTS!");
    }
}
