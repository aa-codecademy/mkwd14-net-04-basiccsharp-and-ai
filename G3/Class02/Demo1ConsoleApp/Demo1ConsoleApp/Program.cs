// See https://aka.ms/new-console-template for more information
Console.WriteLine("Demo Class 02");

int number1;
number1 = 5;

//Int32 number7 = 7;

long number2;
number2 = 7;

long number3 = 1111111111111111111;

bool isValid = true;

float number4;
number4 = 3.14f;

double number5 = 3.14;

decimal number6 = 3.14m;

string text = "Nekoj text";

char character = 'A';

string text1;

string text2 = "";

//text1 = 1; //invalid code

Console.WriteLine("text2 variable is from type: " + text2.GetType());

var number8 = 8;

//var number9; //invalid code

int number10 = 10;

long number11 = number10;

//long number12 = 11;
//int number13 = number12; //invalid code

string name = "Risto";

if (name == "Risto")
{
    Console.WriteLine(number11);

    int number14 = 14;
}

//Console.WriteLine(number14); //invalid code, number14 is not visible outside of the if statement


int n1 = 5;
int n2 = 10;

int result = n1 + n2;
Console.WriteLine("The result of n1 + n2 is: " + result);

int n3 = 15;
n3 += 7;
Console.WriteLine("The result of n3 += 7 is: " + n3);

var isStudent = true;
var isNetStudent = true;

if (isStudent && isNetStudent)
{
    Console.WriteLine("The person is a NET student.");
}