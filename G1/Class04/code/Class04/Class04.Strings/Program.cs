#region String concatenation and escaping

using System.Globalization;

string fName = "Martin";
string lName = "Panovski";

// String Concatenation
string hello1 = "Hello " + fName;

string hello2 = string.Format("Hello there {0} {1}", fName, lName);
Console.WriteLine(hello2);

// String interpolation
string hello3 = $"Hello there again {fName} {lName}";
Console.WriteLine(hello3);


// Escaping charachters in a string using \
string message = "Check your c:\\drive";
Console.WriteLine(message);

string fairElectionsMessage = "We will have a \"fair\" elections";
Console.WriteLine(fairElectionsMessage);

string newLineMessage = "The \\n sign means new line in c#";
Console.WriteLine(newLineMessage);

string folderPaht = "C:\\Users\\Martin\\AvengaAcademy\\C#Basic";
Console.WriteLine(folderPaht);


string folderPathNew = @"C:\Users\Martin\AvengaAcademy\C#Basic";
Console.WriteLine(folderPathNew);


string avengaFolderName = "AvengaProjects";
string userName = "martinpanovski";

string pathToFolder = $@"C:\Users\{userName}\{avengaFolderName}";
Console.WriteLine(pathToFolder);

#endregion

#region String Formating

string myPercentageString = string.Format("This is {0:P}", 0.5);
Console.WriteLine(myPercentageString);

string myCurrencyValue = string.Format("It will cost me {0:C}", 125.45);
Console.WriteLine(myCurrencyValue);

string myStringNumber = string.Format("{0:N}", 190);
Console.WriteLine(myStringNumber);

string cardNumber = string.Format("{0:####-####-####-####}", 1234554477882233);
Console.WriteLine(cardNumber);

string phoneNumber = string.Format("{0:0##/###-###}", 070222333);
Console.WriteLine(phoneNumber);

string myCustomAllinedString1 = string.Format("| {0,5} | {1,18} |", "Id", "Order");
string myCustomAllinedString2 = string.Format("| {0,5} | {1,5} |", 25, "Samsung Galaxy S25");

Console.WriteLine(myCustomAllinedString1);
Console.WriteLine(myCustomAllinedString2);
#endregion


#region String Methods

string msg = "     We are learning C# and it is FUN and EASY. Okay maybe just FUN.   ";

Console.WriteLine(msg.Length);

Console.WriteLine(msg.Trim().Length);

string lower = msg.ToLower();
string upper = msg.ToUpper();


Console.WriteLine(lower);
Console.WriteLine(upper);


string[] splittedString = msg.Split('.');
Console.WriteLine(splittedString[0]);
Console.WriteLine(splittedString[1]);
Console.WriteLine(splittedString[2]);

bool doesStringStartsWith = msg.Trim().StartsWith("W");
Console.WriteLine(doesStringStartsWith);


int indexOfString = msg.IndexOf("FUN");
Console.WriteLine(indexOfString);

int nonExistingString = msg.IndexOf("nope");
Console.WriteLine(nonExistingString);


string substring = msg.Substring(0, 15);
Console.WriteLine(substring);


char[] toChars = msg.ToCharArray();
Console.WriteLine(toChars.Length);


Console.WriteLine(string.Join("-", toChars));

#endregion