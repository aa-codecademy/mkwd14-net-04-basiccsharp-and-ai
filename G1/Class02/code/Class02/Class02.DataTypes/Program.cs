#region DataTypes


// Declaration and initialization of variables 
// using different data types
int number = 154;
int otherNumber = 10500;
short shortNumber = 150;

long bigNumber = 123039348232;

double decimalNumber1 = 10.44;
float decimalNumber2 = 155.45f;
decimal decimalNumber3 = 15545.32345M;

string fullName = "Martin Panovski";

string lastName;
lastName = "Panovski";
Console.WriteLine(lastName);

char character = 'M';

bool isRaining = false;


Console.WriteLine(number);
Console.WriteLine(otherNumber);
Console.WriteLine(bigNumber);
Console.WriteLine(shortNumber);
Console.WriteLine(decimalNumber1);
Console.WriteLine(decimalNumber2);
Console.WriteLine(decimalNumber3);
Console.WriteLine(fullName);
Console.WriteLine(character);
Console.WriteLine(isRaining);

#endregion

#region Implicit data types

var academyName = "Avenga Academy";

// This will not work! The application won't run until fixed.
//academyName = 10; 

var numberOfStudents = 20;
//numberOfStudents = 20.10; // Will not work!

var isSunny = true;
isSunny = false;
#endregion

#region Check data type

Console.WriteLine(isRaining.GetType());

#endregion
