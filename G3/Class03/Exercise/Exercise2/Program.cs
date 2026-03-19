Console.WriteLine("Please enter a number:");
if (!int.TryParse(Console.ReadLine(), out int number))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
    return;
}

var numberOfMessages = 0;

for (int i = 1; i <= number; i++)
{
    if(i % 3 == 0 || i % 7 == 0)
    {
        continue;
    }

    if(numberOfMessages == 100)
    {
        Console.WriteLine("The limit is reached");
        break;
    }

    Console.WriteLine(i);
    numberOfMessages++;
}
