// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Write("Risto");
Console.WriteLine("Ristov");

//Console.Write("Insert a number: ");
//string input = Console.ReadLine();

//Console.WriteLine("You entered: " + input);

string number = "55";

int intNumber = int.Parse(number);
Console.WriteLine("Your number: " + intNumber);


//string number1 = "asdsad";

//int intNumber1 = int.Parse(number1); //throws an exception because the string cannot be parsed to an integer
//Console.WriteLine("Your number: " + intNumber1);

float a = 5.5f;
string aString = a.ToString();
Console.WriteLine("a as string: " + aString);

string decimalNumber = "3.14";
decimal decimalNumberParsed = Convert.ToDecimal(decimalNumber);
Console.WriteLine("Parsed decimal number: " + decimalNumberParsed);

//string decimalNumber1 = "asdsad";
//decimal decimalNumberParsed1 = Convert.ToDecimal(decimalNumber1); //throws an exception because the string cannot be parsed to a decimal
//Console.WriteLine("Parsed decimal number: " + decimalNumberParsed1); 

Console.WriteLine("Please enter a number: ");
string userInput = Console.ReadLine();
int userNumber;

bool isParsed = int.TryParse(userInput, out userNumber);

if (isParsed)
{
    Console.WriteLine("You entered the number: " + userNumber);
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}

//Console.WriteLine("Please enter a number: ");

//if (int.TryParse(Console.ReadLine(), out int userNumber))
//{
//    Console.WriteLine("You entered the number: " + userNumber);
//}
//else
//{
//    Console.WriteLine("Invalid input. Please enter a valid number.");
//}

//if()
//{
//} else
//{
//}

string s = "";
if (s != "" || s != "Risto")
{
}
else
{
}

int dayInTheWeek = 3;

switch (dayInTheWeek)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        {
            Console.WriteLine("Unrecognize day");
            break;
        }
}

string dayName = dayInTheWeek switch
{
    1 => "Monday",
    2 => "Tuesday",
    3 => GetWednesdayMessage(),
    4 => "Thursday",
    5 => "Friday",
    6 => "Saturday",
    7 => "Sunday",
    _ => "Unrecognize day"
};

Console.WriteLine("Day name: " + dayName);

Console.WriteLine("End of the program");

static string GetWednesdayMessage()
{
    Console.WriteLine("It's the middle of the week!");
    return "Wednesday";
}