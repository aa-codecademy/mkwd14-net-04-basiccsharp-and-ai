
#region Exercise 1
double num1 = 10.5;
double num2 = 22.5;
double div1 = num1 / num2;

int num3 = 10;
int num4 = 10;

// If num4 is zero, the following comment explanation will occure
//int num4 = 0;


// The line below will produce a Run Time Error 
// Meaning that the application will fail when
// the code reach line number 12 and it will throw particular type of exception
double div2 = num3 / num4;

Console.WriteLine(div1);
Console.WriteLine(div2);

string fName = "Martin";
string lName = "Panovski";

Console.WriteLine(fName + lName);

string number1 = "9";
string number2 = "3";
Console.WriteLine(number1 + number2);


// The line below will produce a Compile Time Error
// Meaning that you will not be able to build(run) the application

//double divByZero = 10 / 0;

#endregion

#region Exercise 2
int year = 2026;
string text = "We are living the year of ";
Console.WriteLine(text + year);
#endregion

#region Exercise 3

int phoneCredit = 102;
int totalSmsCost = 5;

int smsCount = phoneCredit / totalSmsCost;
Console.WriteLine("You can send total of: " + smsCount + " messages!");

#endregion



