using System.Collections;




#region Arrays

// Declaration of an array in C#


int[] emptyNumbersArray = new int[3];

// Initialization of array elements
emptyNumbersArray[0] = 1;
emptyNumbersArray[1] = 10;
emptyNumbersArray[2] = 20;

// Cannot add new element on non existing index
// This will throw IndexOutOfRangeException
//emptyNumbersArray[3] = 50;

for (int i = 0; i < emptyNumbersArray.Length; i++)
{
    Console.WriteLine(emptyNumbersArray[i]);
}

string[] names = new string[]
{
    "Martin",
    "Mario",
    "Dimitar",
    "Ognen",
    "Damjan"
};

double[] decimalNumbers = [10.5, 20.4, 100.12];

foreach (string name in names)
{
    Console.WriteLine(name);
}

foreach (double number in decimalNumbers)
{
    Console.WriteLine(number);
}


var mixedArray = new int[] { 1, 23, 34, 5 };


// Ways of declaration and use of arrays with mixed types in it.
// AVOID and DON't use this unless you need to do so for some reason!!!
var mixedArrayValues = new object[] { 1, 1.1, true, "Martin" };
ArrayList mixed = new ArrayList { 1, 2.4, true, false };

#endregion

#region Array Methods

int[] evenNumbers = new int[] { 2, 4, 6, 8, 10, 2, 4 };

// Reverse the array elements
//Array.Reverse(evenNumbers);

Console.WriteLine("Array of even numbers after Reverse()");
foreach (var num in evenNumbers)
{
    Console.WriteLine(num);
}


int indexFound = Array.IndexOf(evenNumbers, 2);
Console.WriteLine("The index of number 2 is " + indexFound);
#endregion


#region Array Resize method using example use case

string[] usernames = new string[0];

do
{
    Console.Clear();
    Console.WriteLine("Please enter a username:");
    string userInput = Console.ReadLine();

    Array.Resize(ref usernames, usernames.Length + 1);
    usernames[usernames.Length - 1] = userInput;

    Console.WriteLine("Do you want to insert new username? Y/N");
    userInput = Console.ReadLine();

    if (userInput == "n" || userInput == "N")
        break;


} while (true);

foreach (var username in usernames)
{
    Console.WriteLine(username);
}



int[] test = new int[] { 1, 2, 3, 4, 5 };

Array.Resize(ref test, 10);

test[5] = 10;
test[6] = 25;
test[7] = 25;
test[8] = 25;



int[][] arrayOfArrays = new int[][] 
{
    new int[] {1, 2},
    new int[] {1, 2},
    new int[] {1, 2},
};



#endregion