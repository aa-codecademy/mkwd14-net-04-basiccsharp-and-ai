while(true)
{
    Console.Write("Please enter a number: ");
    var input = Console.ReadLine();

    decimal number;
    while (!decimal.TryParse(input, out number))
    {
        Console.Write("Invalid input. Please enter a valid number: ");
        input = Console.ReadLine();
    }

    Console.WriteLine(NumberStats(number));

    Console.WriteLine("Press X to exit or any other key to enter new number");
    var key = Console.ReadLine();

    if(key.Equals("X", StringComparison.OrdinalIgnoreCase)) //(key.ToUpper() == "X")
    {
        break;
    }
}



static string NumberStats(decimal number)
{
    var result = $"Stats for: {number}\n";

    result += number % 2 == 0 ? " - Even\n" : " - Odd\n";
    result += number >= 0 ? " - Positive\n" : " - Negative\n";
    result += number % 1 == 0 ? " - Integer\n" : " - Decimal\n";

    return result;
}