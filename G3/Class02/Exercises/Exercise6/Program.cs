Console.WriteLine("Enter a number between 1 - 3.");
var input = Console.ReadLine();

switch(input)
{
    case "1":
        Console.WriteLine("You got a new car!");
        break;
    case "2":
        Console.WriteLine("You got a new plane!");
        break;
    case "3":
        Console.WriteLine("You got a new bike!");
        break;
    default:
        Console.WriteLine("Invalid input. Please enter a number between 1 - 3.");
        break;
}