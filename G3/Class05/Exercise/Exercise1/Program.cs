using Exercise1;

#region Demo
Human human1 = new Human();
human1.FirstName = "Risto";
human1.LastName = "Panchevski";
human1.Age = 36;

Human human2 = new Human()
{
    FirstName = "Risto",
    LastName = "Panchevski",
    Age = 36
};

var human3 = new Human
{
    FirstName = "Risto",
    LastName = "Panchevski",
    Age = 36
};

Human human4 = new()
{
    FirstName = "Risto",
    LastName = "Panchevski",
    Age = 36
};

Human human5 = new Human("Risto", "Panchevski", 36);
var human6 = new Human("Risto")
{
    LastName = "Panchevski",
    Age = 36
};
#endregion

Console.WriteLine("Enter your name:");
var firstName = Console.ReadLine();

Console.WriteLine("Enter your last name:");
var lastName = Console.ReadLine();

int age;
Console.WriteLine("Enter your age:");
while (!int.TryParse(Console.ReadLine(), out age))
{
    Console.WriteLine("Please enter a valid number for age:");
}

Human human7 = new Human(firstName, lastName, age);
Console.WriteLine(human7.GetPersonStats());
//human7.PrintPersonStats();
Console.WriteLine($"Full Name: {human7.FullName}");

//Human human8 = new Human();
//Console.WriteLine("Enter your name:");
//human8.FirstName = Console.ReadLine();

//Console.WriteLine("Enter your last name:");
//human8.LastName = Console.ReadLine();

//Console.WriteLine("Enter your age:");
//int age1;
//while (!int.TryParse(Console.ReadLine(), out age1))
//{
//    Console.WriteLine("Please enter a valid number for age:");
//}
//human8.Age = age1;