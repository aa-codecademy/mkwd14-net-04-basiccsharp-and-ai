namespace Class07.Inheritance.Models;

public class Dog : Animal
{
    public string Race { get; set; }


    public Dog()
    {
        Console.WriteLine("A new instance of a Dog is created and also called the default(empty) Parent constructor!");
        Thread.Sleep(2000);
    }


    public void Bark()
    {
        Console.WriteLine("Woof woof woof!");
    }

    public override void Eat()
    {
        Console.WriteLine($"Hi people! I am {Name} the {Type} and I am eating!");
    }
}
