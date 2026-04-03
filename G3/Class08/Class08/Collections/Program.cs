using System.Collections;


Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n============== COLLECTIONS ==============");
Console.ResetColor();
// Collections are fundamental data structures that allow you to store, manage, and manipulate groups of related objects. 


// IEnumerable: An Interface which represents a collection that can be enumerated and iterated over. 
// Note: Interfaces will be a topic covered in the Advanced C# subject. 
static void PrintCollectionItems(IEnumerable collection)
{
    Console.WriteLine($"\nPrinting collection of type {collection}");
    foreach (var item in collection)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}


#region Array & ArrayList
Console.WriteLine("\n============== Array & ArrayList ==============");
// Arrays => collection type with pre-defined length and items of same data type
// Usecase: used when a fixed-size collection is needed (typically some 'constant' arrays, e.g. application colors)
// NOTE: Not suitable for data manipulation !!!

int[] array = new int[] { 1, 2, 3, 4 };
Array.Resize(ref array, array.Length + 1);
//array[array.Length - 1] = 5;
array[^1] = 5; // same as above, simpler syntax
PrintCollectionItems(array);


// ArrayList => collection of objects (items of any kind), without fixed size
// NOTE: Avoid using them, since they are not type-safe and can lead to many potential issues.
ArrayList arrayList = new ArrayList() { "string text", true, 0, 123.343 };
arrayList.Add(1233424);
PrintCollectionItems(arrayList);

#endregion


#region List
Console.WriteLine("\n============== List<T> ==============");
// Most used collection type !!!
// List<T> => generic collection that stores items of the same type T
// T => the type of elements in the list (placeholder for any datatype)
// NOTE: List<T> provides methods for manipulating elements and it is more flexible than arrays because it can resize dynamically

List<string> stringList = new List<string>() { "text 1", "text 2", "text 3" };
List<int> integerList = new();

integerList.Add(1);
integerList.Add(2);
integerList.Add(3);
integerList.Remove(2);

stringList.Add("text 4");

PrintCollectionItems(integerList);
PrintCollectionItems(stringList);
Console.WriteLine(stringList.Count);

#endregion


#region HashSet
Console.WriteLine("\n============== HashSet<T> ==============");
// HashSet => generic collection that stores unique elements. It does not allow duplicate elements.
// Usecase: for collection of unique elements without duplicates.

HashSet<int> hashSetInts = new HashSet<int>() { 1, 2, 3, 3, 3, 4, 5 };
hashSetInts.Add(1);

Console.WriteLine(hashSetInts.Count); // 5
bool hasValue = hashSetInts.TryGetValue(10, out int value);
Console.WriteLine(hasValue ? value : "VALUE NOT FOUND");

PrintCollectionItems(hashSetInts);

#endregion


#region Dictionary
Console.WriteLine("\n============== Dictionary<TKey, TValue> ==============");
// Dictionary => generic collection of key-value pairs.
// TKey => placeholder for data type of the keys
// TValue => placeholder for data type of the values
// Usecase: Dictionaries are used when you need to store key-value pairs for quick lookup and retrieval.
// NOTE: Dictionaries do not allow duplicate keys, and each key must be unique within the collection.

// Syntax: Dictionary<TKey, TValue> dictionary = new Dictionary<TKey, TValue>();
Dictionary<string, int> dictionary = new Dictionary<string, int>()
{
    { "One", 1 },
    { "Two", 2 },
    { "Three", 3 }
};

// ===> Accessing values in a dictionary
// 1) using dictionary[key] syntax
Console.WriteLine(dictionary["One"]); // 1
//Console.WriteLine(dictionary["dfghfdfg"]); // KeyNotFoundException

// 2) using TryGetValue method
bool keyExists = dictionary.TryGetValue("Four", out int requestedValue);
Console.WriteLine(keyExists ? requestedValue : "Value not found");


// ===> Creating an empty dictionary
Dictionary<string, string> lastNames = new Dictionary<string, string>();

// Adding elements to an empty dictionary
// 1) with Add(key,value)
lastNames.Add("Bob", "Bobsky");
//lastNames.Add("Bob", "Bobsky"); // Exception !!!

// 2) with TryAdd(key,value) => better way
lastNames.TryAdd("Bob", "Bobsky");
lastNames.TryGetValue("Bob", out string lastName);
Console.WriteLine(lastName);

// 3) with [key] = value;
lastNames["John"] = "Doe";

Console.WriteLine(lastNames["John"]);

// ===> Printing dictionary
PrintCollectionItems(lastNames); // will be printed as key-value pairs => [Bob, Bobsky] [John, Johnsky]

foreach (KeyValuePair<string,string> item in lastNames)  // here 'var' is of type: KeyValuePair<string, string>
{
    Console.WriteLine($"{item.Key} {item.Value}");
}

#endregion


#region Stack & Queue
Console.WriteLine("\n============== Stack & Queue ==============");
// => don't have indexing of elements

// Stack => Last in, first out (LIFO) collection. Stack is a generic collection (Stack<T>)
// NOTE: Stack<T> provides Push(), Pop(), and Peek() methods to add, remove, and access elements.

Stack<int> stack = new Stack<int>();

stack.Push(1);
stack.Push(2);
stack.Push(3);

//stack[0] // Cannot apply indexing to stack (or queue)
PrintCollectionItems(stack); // 3 2 1

// Pop() => *removes and returns* the last added item in the stack
int lastAddedItem = stack.Pop();
Console.WriteLine("Last added value is " + lastAddedItem + ". Let's remove it :D");

// Peek() => *returns* the last added item in the stack (does not remove it from the collection)
int lastItem = stack.Peek();
Console.WriteLine("Last added value is " + lastItem);

PrintCollectionItems(stack);


// Queue => First in, first out (FIFO) generic collection
// Usecase: Queues are used in scenarios such as scheduling, implementing a message queue etc.
// Note: Queue<T> provides Enqueue(), Dequeue(), and Peek() methods to add, remove, and access elements.

Queue<int> queue = new Queue<int>();
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
PrintCollectionItems(queue); // 1 2 3

// Dequeue() => *removes and returns* the first added item in the queue
int lastItemQueue = queue.Dequeue();
Console.WriteLine(lastItemQueue);

// Peek() => *returns* the first item in the queue (does not remove it from the collection)
int firstAddedItemValue = queue.Peek();
Console.WriteLine($"The value of the FIRST item is: {firstAddedItemValue}");
#endregion


Console.ReadLine();