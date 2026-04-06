using Domain.Models;
using System.Collections;

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n================== Language Integrated Query (LINQ) ==================\n\n");
Console.ResetColor();
// LINQ (Language Integrated Query) is a set of features in .NET that provides a unified way to query data from different data sources
// LINQ allows you to write queries directly in C# code, making it easier to work with data from in-memory collections, databases, XML, and other sources
// LINQ query => expression that retrieves data from a data source


static void PrintCollectionItems(IEnumerable collection)
{
    Console.WriteLine($"\nPrinting collection of type {collection}");
    foreach (var item in collection)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine("--------------------------");
}


#region Data Samples
List<int> integersSample = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
List<Dog> dogsSample = new List<Dog>()
{
    new Dog("Aks", 7),
    new Dog("Lav", 5),
    new Dog("Sparky", 2),
    new Dog("Butch", 1),
    new Dog("Zoe", 3),
    new Dog("Sia", 1),
    new Dog("William", 4),
    new Dog("Billy", 1),
    new Dog("Buck", 2)
};
#endregion


#region Where
Console.WriteLine("\n=============== Where ===============\n");
// Where => filters a collection of values based on a condition (written as lambda expression/arrow function)
// Returns a new collection containing only the elements that satisfy the condition

// Example: Get only the even numbers
// List<int> numbersDivisibleByTwo = integers.Where(num => num % 2 == 0); // Error
// => returns IEnumerable by default
// => Using ToList to convert the result from IEnumerable to List type
List<int> numbersDivisibleByTwo = integersSample.Where(num => num % 2 == 0).ToList();
PrintCollectionItems(numbersDivisibleByTwo);

// Example: Get only the dogs older than 3 years
List<Dog> olderThan3Dogs = dogsSample.Where(dog => dog.Age > 3).ToList();
PrintCollectionItems(olderThan3Dogs);

// Example: Get only the dogs older than 5 years, with Name starting on 'A'
List<Dog> olderThan3StartingWithADog = dogsSample.Where(dog => dog.Age > 5 && dog.Name.StartsWith('A')).ToList();

// BAD WAY !
//List<Dog> olderThan3StartingWithADogPart2 = dogsSample
//    .Where(dog => dog.Age > 5)
//    .Where(dog => dog.Name.StartsWith('A'))
//    .ToList(); 

// *NOTE* If you have multiple conditions don't chain multiple Where methods, simply write the conditions with logical operator (&&, ||)

PrintCollectionItems(olderThan3StartingWithADog);

#endregion


#region Select
Console.WriteLine("\n\n=============== Select ===============\n");
// Select => projects each element of a collection into a new form
// Select is used to transform elements of a collection, such as extracting specific properties from objects or performing calculations on values.

// Example: Get Squared Numbers
List<int> numbersSquares = integersSample.Select(num => num * num).ToList();
PrintCollectionItems(numbersSquares);

// Example: Select only the dogs' names
List<string> dogsNames = dogsSample.Select(dog => dog.Name).ToList();
PrintCollectionItems(dogsNames);

// *Combining Where & Select*
// Example: Get dogs names of dogs with 1 year
List<string> dogsNames2 = dogsSample
    .Where(dog => dog.Age == 1)
    .Select(dog => dog.Name)
    .ToList();

PrintCollectionItems(dogsNames2);

#endregion


#region First, FirstOrDefault, Last, LastOrDefault

Console.WriteLine("\n\n=============== First, FirstOrDefault ===============\n");
// First => returns the first element of a collection
// FirstOrDefault => returns the first element of a collection, or a default value if the collection contains no elements

// Example: Return the first number
int firstNumber = numbersSquares.First();

// Example: Get first dog with age higher than 1
// Dog firstDogOlderThan1 = dogsSample.Where(dog => dog.Age > 1).First(); // redundant Where usage
Dog firstDogOlderThan1 = dogsSample.First(dog => dog.Age > 1); // more concise
Console.WriteLine(firstDogOlderThan1);

// Example: Get first dog with age higher than 10
// Dog firstDogOlderThan10 = dogsSample.First(dog => dog.Age > 10); // InvalidOperationException: 'Sequence contains no matching element'
Dog firstDogOlderThan10 = dogsSample.FirstOrDefault(dog => dog.Age > 10);
if (firstDogOlderThan10 == null)
{
    Console.WriteLine("No dog older than 10 found!");
}
else
{
    Console.WriteLine(firstDogOlderThan10);
}


Console.WriteLine("\n\n=============== Last, LastOrDefault ===============\n");
// Last => returns the last element of a collection
// LastOrDefault => returns the last element of a collection, or a default value if the collection contains no elements

Dog lastDog = dogsSample.Last();
Console.WriteLine("This is the last dog in the list " + lastDog.Name);

Dog last2YearDog = dogsSample.LastOrDefault(d => d.Age == 2);
Console.WriteLine(last2YearDog.Name);

#endregion


#region LINQ Syntax (Bonus)
Console.WriteLine("\n\n=============== LINQ Syntax (Bonus) ===============\n");

// Example: Get numbers larger than 5

// 1) Method syntax
var numbersLargerThan5MethodSyntax = integersSample.Where(n => n > 5);

// 2) Query-like syntax
var numbersLargerThan5QuerySyntax = from num in integersSample
                                    where num > 5
                                    select num;

// Example: Get all 2 year old dogs names (query syntax)
List<string> dogsOver2Names = (from dog in dogsSample
                               where dog.Age == 2
                               select dog.Name).ToList();

#endregion


Console.ReadLine();