Console.WriteLine("Enter a number:");
if(!int.TryParse(Console.ReadLine(), out int number1))
{
    Console.WriteLine("Invalid input. Please enter a valid integer.");
    return;
}

Console.WriteLine("Enter a number:");
if (!int.TryParse(Console.ReadLine(), out int number2))
{
    Console.WriteLine("Invalid input. Please enter a valid integer.");
    return;
}

int largerNumber;

if (number1 > number2)
{
    Console.WriteLine($"{number1} is greater than {number2}");
    largerNumber = number1;
}
else if (number1 < number2)
{
    Console.WriteLine($"{number2} is greater than {number1}");
    largerNumber = number2;
}
else
{
    Console.WriteLine("Numbers are equal");
    largerNumber = number1; // or number2, since they are equal
}

if(largerNumber % 2 == 0)
{
    Console.WriteLine($"{largerNumber} is an even number.");
}
else
{
    Console.WriteLine($"{largerNumber} is an odd number.");
}