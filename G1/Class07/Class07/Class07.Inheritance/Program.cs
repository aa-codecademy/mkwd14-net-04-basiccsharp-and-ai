
using Class07.Inheritance.Models;

Animal elephant = new Animal() 
{ 
    Id = 1, 
    Name = "Dambo", 
    Type = "Elephant" 
};
elephant.PrintInfo();
elephant.Eat();
Console.WriteLine("---------------------------------------");

Dog dog = new Dog()
{
    Id = 2,
    Name = "Spikey",
    Type = "Dog",
    Race = "Labrador"
};
dog.PrintInfo();
dog.Eat();
dog.Bark();
Console.WriteLine("---------------------------------------");


Cat cat = new Cat()
{
    Id = 3,
    Name = "Garfield",
    Lazyness = "Very",
};
cat.PrintInfo();
cat.Eat();
cat.Meow();
Console.WriteLine("---------------------------------------");



Parrot riki = new Parrot(4, "Riki", "Parrot", "Blue");
riki.PrintInfo();
riki.Fly();
riki.Eat();
Console.WriteLine("---------------------------------------");



Parrot miki = new Parrot()
{
    Id = 5,
    Name = "Miki",
    Type = "Parrot",
    Color = "Yellow"
};
miki.PrintInfo();
miki.Fly();
miki.Eat();
Console.WriteLine("---------------------------------------");