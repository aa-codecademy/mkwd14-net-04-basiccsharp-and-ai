#region Methods declaration and usage


// Method that print in console
// Doesn't return value or it returns 'void'
// Doesn't accept input parameters
static void SaySomething()
{
    Console.WriteLine("Hello there I am learning C# Methods!");
    Console.ReadLine();
}

SaySomething();

// Method that print in console
// Doesn't return value or it returns 'void'
// Accept input parameter of type string
static void SayHelloToSomeone(string person)
{
    Console.WriteLine("Hello there " + person + "! I have to tell you something!");
    Console.ReadLine();
}
SayHelloToSomeone("Damjan");
SayHelloToSomeone("Mario");


// Method that print in console
// Doesn't return value or it returns 'void'
// Accept input parameters of type boolean and string
static void SendEmail(bool isSenderValid, string message)
{
    if (isSenderValid)
    {
        Console.WriteLine("The message was sent! Message: " + message);
    }
    else
    {
        Console.WriteLine("The message was not sent! Message: " + message);
    }
    Console.ReadLine();
}
SendEmail(true, "Hi Martin, here is my C# homework!");
SendEmail(false, "Hi Martin, here is my JS project!");


// Method that returns a value 
// Returns value of 'int'
// Accpet input parameters a and b also of type 'int'
static int Sum(int a, int b)
{
    return a + b;
}
Console.WriteLine(Sum(10, 22));
Console.WriteLine(Sum(100, 222334));


// Method that returns a value 
// Returns value of 'int'
// Accpet input parameters a and b also of type 'int'
static int Subtract(int a, int b)
{
    return a - b;
}
Console.WriteLine(Subtract(100, 40));
Console.WriteLine(Subtract(1000, Sum(10, 20)));


static void PrintSomething()
{
    Console.WriteLine("Hello there");
}


#endregion


#region Exercise

static double Multiply(double a, double b)
{
    return a * b;
}

static double Divide(double a, double b)
{
    return a / b;
}


Console.WriteLine("Enter operation * or /");
string operation = Console.ReadLine();

Console.WriteLine("Enter the first number:");
bool isParsedNum1 = double.TryParse(Console.ReadLine(), out double num1);

Console.WriteLine("Enter the second number:");
bool isParsedNum2 = double.TryParse(Console.ReadLine(), out double num2);

if(!isParsedNum1 || !isParsedNum2)
{
    Console.WriteLine("Please enter only number values!");
}
else
{
    if(operation == "*")
    {
        double result = Multiply(num1, num2);
        Console.WriteLine("The result is: " + result);
    }
    else if(operation == "/")
    {
        if(num2 == 0)
        {
            Console.WriteLine("Cannot devide by zero, please try again!");
        }
        else
        {
            double result = Divide(num1, num2);
            Console.WriteLine("The result is: " + result);
        }
    }
    else
    {
        Console.WriteLine("Please insert valid operation!");
    }
}


#endregion