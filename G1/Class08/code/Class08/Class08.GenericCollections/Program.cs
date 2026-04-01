

using Class08.GenericCollections.Models;
using System.Collections;

static void PrintCollection(IEnumerable collection, string name)
{
    Console.WriteLine($"Collection {name} items: ");
	foreach (var item in collection)
	{
        Console.Write($"{item} ");
	}
    Console.WriteLine();
    Console.WriteLine("----------------------------------");
}

static void PrintUsers(List<User> collection, string name)
{
    Console.WriteLine($"Collection {name} items: ");
    foreach (var item in collection)
    {
        Console.WriteLine($"{item.FullName} - {item.Age} ");
    }
    Console.WriteLine("----------------------------------");
}


#region Generic Collections - List<>

// List of integers
List<int> numbers = new List<int>();
numbers.Add(1);
numbers.Add(10);
numbers.Add(123);
numbers.AddRange(11, 22, 32, 43, 54);

numbers.Remove(32);
numbers.Remove(1234); // This will not throw exception, it will return false if non existing item is tried to delete

PrintCollection(numbers, "List<int>");

// List of strings
List<string> names = new List<string>()
{ 
  "Martin",
  "Mario",
  "Klementina",
  "Dragan"
};
PrintCollection(names, "List<string>");


// List of User 
List<User> users = new List<User>()
{
    new User() { Id = 1, FullName = "Bob Bobsky", Age = 33},
    new User() { Id = 2, FullName = "Jill Wayne", Age = 22},
    new User() { Id = 3, FullName = "John Doe", Age = 18},
};
users.Remove(users[2]);

PrintUsers(users, "List<User>");
Console.WriteLine(users.Count);

#endregion

#region ArrayList

ArrayList mixedArray = new ArrayList() { 1, 10, true, false, new User(), "Martin" };
mixedArray.Add(false);
mixedArray.Remove("Maritn");
#endregion

#region Generic Collections - Dictionary<,>

Dictionary<string, string> songList = new Dictionary<string, string>()
{
    {"song1", "Winds of Change" },
    {"song2", "Nothing else matters" },
    {"song3", "Living on a prayer" }
};

Console.WriteLine(songList["song1"]);
Console.WriteLine(songList.Count);

if (songList.ContainsKey("song3"))
{
    Console.WriteLine(songList["song3"]);
}
else
{
    Console.WriteLine("Key 'song3' does not exist in the dictionary!");
}

bool item = songList.TryGetValue("song5", out string songValue);
if (item)
{
    Console.WriteLine($"Here you are your song: {songValue}");
}
else
{
    Console.WriteLine("Something went wrong! No such song available!");
}


Dictionary<int, string> students = new Dictionary<int, string>()
{
    { 1, "Martin" },
    { 2, "Mario" },
    { 3, "Klementina" },
};
PrintCollection(students, "Dictionary of students");

foreach (var student in students)
{
    Console.WriteLine($"{student.Key} {student.Value}");
}


Dictionary<int, User> trainers = new Dictionary<int, User>()
{
    { 1, new User() { Id = 1, FullName = "Bob Bobsky", Age = 33 } },
    { 2, new User() { Id = 2, FullName = "Greg Smith", Age = 31 } },
    { 3, new User() { Id = 3, FullName = "John Doe", Age = 35 } }
};


foreach (var trainer in trainers)
{
    Console.WriteLine($"{trainer.Key} {trainer.Value.FullName}");
}

#endregion

#region Generic Collections - Queue<> First In First Out

Queue<int> numbersQueue = new Queue<int>();
numbersQueue.Enqueue(1);
numbersQueue.Enqueue(2);
numbersQueue.Enqueue(3);
numbersQueue.Enqueue(4);
numbersQueue.Enqueue(5);

numbersQueue.Dequeue();
PrintCollection(numbersQueue, "Queue");

int firstInTheQueue = numbersQueue.Peek();
Console.WriteLine(firstInTheQueue);
Console.WriteLine(numbersQueue.Count);




#endregion

#region Generic Collections - Stack<> Last In First Out

Stack<string> namesStack = new Stack<string>();
namesStack.Push("Bob");
namesStack.Push("Dimitar");
namesStack.Push("Ognen");
namesStack.Push("Damjan");

namesStack.Pop();

PrintCollection(namesStack, "Stack");
Console.WriteLine(namesStack.Count);
Console.WriteLine(namesStack.Peek());

#endregion