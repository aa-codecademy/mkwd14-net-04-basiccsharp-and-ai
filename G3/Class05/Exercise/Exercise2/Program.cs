using Exercise2;

Console.WriteLine("Please enter dog name:");
string name = Console.ReadLine();

Console.WriteLine("Please enter dog breed:");
string breed = Console.ReadLine();

Console.WriteLine("Please enter dog color:");
string color = Console.ReadLine();

Dog dog = new Dog
{
    Name = name,
    Breed = breed,
    Color = color
};

Console.WriteLine("Choose an action for the dog (1-3):");
Console.WriteLine("1. Eat");
Console.WriteLine("2. Play");
Console.WriteLine("3. Chase Tail");

int option;
while (!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 3)
{
    Console.WriteLine("Invalid option. Please enter a number between 1 and 3:");
}

switch(option)
{
    case 1:
        Console.WriteLine(dog.Eat());
        break;
    case 2:
        Console.WriteLine(dog.Play());
        break;
    case 3:
        Console.WriteLine(dog.ChaseTail());
        break;
}