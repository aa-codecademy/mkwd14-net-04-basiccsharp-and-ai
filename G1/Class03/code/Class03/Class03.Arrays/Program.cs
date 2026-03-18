#region Arrays

// Declaration of an array in C#
using System.Collections;

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