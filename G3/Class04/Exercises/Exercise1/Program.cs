int number1 = InputNumber();
int number2 = InputNumber();

Console.WriteLine("Please enter an operator (+ or -):");
string operatorInput = Console.ReadLine();

switch(operatorInput)
{
    case "+":
        int result = Sum(number1, number2);
        Console.WriteLine($"The result of {number1} + {number2} is: {result}");
        break;
    case "-":
        Console.WriteLine($"The result of {number1} - {number2} is: {Subtract(number1, number2)}");
        break;
    default:
        Console.WriteLine("Invalid operator.");
        break;
}

static int InputNumber()
{
    int number;
    Console.WriteLine("Enter a number:");

    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer:");
    }

    return number;
}

static int Sum(int num1, int num2)
{
    return num1 + num2;
}

static int Subtract(int num1, int num2)
{
    return num1 - num2;
}
