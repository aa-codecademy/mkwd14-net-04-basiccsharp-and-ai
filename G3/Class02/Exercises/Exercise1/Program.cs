// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exercise 1");

double a;
double b;

a = 3;
b = 2;

var result = a / b;

Console.WriteLine($"The result of {a} divided by {b} is {result}");

int n1 = 3;
int n2 = 2;

var intResult = n1 / n2;
Console.WriteLine($"The result of {n1} divided by {n2} is {intResult}");

var doubleResult = (double) n1 / n2;
Console.WriteLine($"The result of {n1} divided by {n2} is {doubleResult}");

string s1 = "9";
string s2 = "3";
var resultString = s1 + s2;
Console.WriteLine($"The result of {s1} plus {s2} is {resultString}");