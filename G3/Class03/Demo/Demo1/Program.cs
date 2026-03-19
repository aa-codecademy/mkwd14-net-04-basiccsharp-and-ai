int[] arrayOfNumbers = new int[5];

arrayOfNumbers[3] = 42;

Console.WriteLine(arrayOfNumbers[0]);
Console.WriteLine(arrayOfNumbers[3]);
//Console.WriteLine(arrayOfNumbers[5]); // This line will throw an IndexOutOfRangeException because the valid indices are 0 to 4.

string[] arrayOfStrings = { "Nikola", "Martina", "Ilija" };
string[] arrayOfStrings1 = new string[] { "Nikola", "Martina", "Ilija" };
string[] arrayOfStrings2 = new string[3] { "Nikola", "Martina", "Ilija" };
//string[] arrayOfStrings3 = new string[5] { "Nikola", "Martina", "Ilija" }; // This line will throw a compile-time error because the number of elements provided (3) does not match the specified size of the array (5).

Array.Sort(arrayOfStrings);
var indexOfMartina = Array.IndexOf(arrayOfStrings, "Martina"); // This will return the index of "Martina" in the sorted array. If the search name does not exist, -1 will be returned.

Array.Resize(ref arrayOfStrings, 1); // This will resize the array to have 5 elements. The new elements will be initialized to null.

Console.WriteLine(arrayOfNumbers.Length);