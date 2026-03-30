using Class07.Enums.Enums;
using Class07.MathLibrary;
using System.Data.Common;

Console.WriteLine(DaysOfWeek.Monday);
Console.WriteLine(Convert.ToInt32(DaysOfWeek.Monday));


Console.WriteLine("Please enter day of week:");
string input = Console.ReadLine();

// Bad way! Error prone!
//if(input == "Satrday" || input == "Sunday")
//{
//    Console.WriteLine("Yeey! It is a weekend!");
//}

// Better way! 
if (input == DaysOfWeek.Saturday.ToString() || input == DaysOfWeek.Sunday.ToString())
{
    Console.WriteLine("Yeey! It is a weekend!");
}


MathOperations.Sum(10, 20);

Cat cat = new Cat();