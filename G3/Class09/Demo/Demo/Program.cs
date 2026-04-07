// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Please enter a number:");
string input = Console.ReadLine();


Console.WriteLine("Please enter a second number:");
string input2 = Console.ReadLine();

try
{
    int number1 = int.Parse(input);
    int number2 = int.Parse(input2);

    Console.WriteLine($"Result: {number1 / number2}");
}
catch (FormatException ex)
{
    Console.WriteLine($"Error: one of the inputs is not a valid number. Please enter a valid integer. ({ex.Message})");
    throw; // Re-throwing the exception to allow it to propagate further if needed
}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine($"Error: cannot divide by zero. Please enter a non-zero second number. ({ex.Message})");
//}
catch (Exception ex)
{
    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
}

Console.WriteLine("Please enter Y to continue or X to stop:");
string continueInput = Console.ReadLine();

if (continueInput != "Y" && continueInput != "X")
{
    throw new ArgumentException("Invalid input. Please enter 'Y' to continue or 'X' to stop.");
}
