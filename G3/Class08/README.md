# Class 08 - Collection Types 😏

**Trainer:** `Ilija Mitev`  <br>
Contact: `ilija.mitev3@gmail.com`

---

## Agenda 📋

- Introduction to generic collections in C#
- Types and differences between generic collections
- Methods for manipulating generic collections
- Introduction to LINQ

---

# Collections and Why We Need Them

Collections allow us to:
- Store multiple values
- Work more flexibly with data
- Organize data more efficiently
- Choose different structures for different scenarios

Arrays are useful, but sometimes:
- We don’t know the size in advance
- We need special ordering
- We need key-value pairs

That’s why we use **generic collections in C#**.

🤖 Let’s ask AI  
> Explain the concept of generic in a beginner-friendly manner. <br>
> Explain why generic collections in C# are more flexible than arrays, using a beginner-friendly example.

---

# Generic Collections

Generic collections in C#:
- Are type safe
- Are dynamic (not fixed size like arrays)
- Require specifying a type using `< >`
- Offer built-in manipulation methods

We use them:
- To dynamically add/remove items
- To retrieve items in specific order (FIFO/LIFO)
- To store key-value data

---

# Types of Generic Collections

Collections are not one-size-fits-all.

Different types exist for different purposes:

- **List** – flexible, indexed, multi-purpose
- **Dictionary** – key-value storage
- **Queue** – FIFO (First In First Out)
- **Stack** – LIFO (Last In First Out)

🤖 Let’s ask AI  
> In C#, explain the difference between List, Dictionary, Queue and Stack using simple real-life analogies. When is each one of these best suitable for use?

---

# List

A List:
- Is indexed
- Has dynamic size
- Allows adding/removing items
- Is more flexible than arrays

```csharp
List<string> names = new List<string>();

names.Add("Bob");
names.Add("Midge");
names.Add("Red");

names.Remove("Red");

names.Count;

List<int> numbers = new List<int>() { 2, 89, 4, 8, 6 };
```

---

# Dictionary

Dictionary stores data in key-value pairs.

```csharp
Dictionary<int, string> people = new Dictionary<int, string>();

people.Add(1, "Bob");
people.Add(2, "Midge");
people.Add(3, "Red");

people.Remove(3);

people.ContainsKey(2);
people.ContainsValue("Midge");

people.Count;

people[1];

Dictionary<string, bool> CheckList = new Dictionary<string, bool>()
{
    {"Potatoes", false},
    {"Butter", true},
    {"Salt", false},
    {"Pepper", false}
};

CheckList.First().Key;
CheckList.First().Value;
```

🤖 Let’s ask AI  
> Why are dictionaries in C# useful compared to using two separate lists?

---

# Queue and Stack

## Queue (FIFO)

```csharp
Queue<string> people1 = new Queue<string>();

people1.Enqueue("Bob");
people1.Enqueue("Midge");
people1.Enqueue("Red");

people1.Dequeue();
people1.Peek();
```

## Stack (LIFO)

```csharp
Stack<string> people2 = new Stack<string>();

people2.Push("Bob");
people2.Push("Midge");
people2.Push("Red");

people2.Pop();
people2.Peek();
```

🤖 Let’s ask AI  
> Explain FIFO and LIFO in C# using real-world examples so a beginner can understand.

---

# Methods for Manipulation

For Dictionary and List:
- Add()
- Remove()
- Count

For Stack and Queue:
- Enqueue() / Push()
- Dequeue() / Pop()
- Peek()

---

# EXERCISE – PhoneBook

Create a PhoneBook Dictionary with 5 names and phone numbers.

Through the console ask the person to enter a name.

Try and find that name's phone number in your PhoneBook:
- If you can find it, print it
- If you can’t, print an error message

---

# EXERCISE 1

Create a class Song with:
- Title
- Length
- Genre (enum: Rock, Hip_Hop, Techno, Classical)

Create a class Person with:
- Id
- FirstName
- LastName
- Age
- FavoriteMusicType (Genre enum)
- FavoriteSongs (List of Songs)

Create a method called GetFavSongs() that:
- Prints all titles of favorite songs
- Or prints a message that the person hates music if the list is empty

---

# LINQ

LINQ allows us to write queries for collections in C#.

It:
- Uses method chaining
- Works with IEnumerable
- Returns IEnumerable
- Often needs conversion using ToList()

🤖 Let’s ask AI  
> Explain what IEnumerable is in C# in a simple way and why LINQ methods usually return it.

---

# Common LINQ Methods

## Where()

Filters items by condition.

## First() / Last()

Returns first or last item.  
Throws error if none exist.

## FirstOrDefault() / LastOrDefault()

Safe versions that return default value.

## Select()

Projects values from objects.

## ToList()

Converts IEnumerable to List.

```csharp
List<string> strings = new List<string>(){"bob","midge","Red","Kitty","Fez"};

var threeLetterNames = strings.Where(x => x.Length == 3).ToList();

var numberOfLetters = strings.Select(x => x.Length).ToList();

numberOfLetters.First();
numberOfLetters.FirstOrDefault();

numberOfLetters.Last();
numberOfLetters.LastOrDefault();
```

---

# EXERCISE 2

Select the person Jerry and add all the songs which start with the letter B.

Select the person Maria and add all the songs with length longer than 6 min.

Select the person Jane and add all the songs that are of genre Rock.

Select the person Stefan and add all songs shorter than 3 min and of genre Hip-Hop.

Select all persons from the persons array that have 4 or more songs.

---

## Questions? ❓

If you have any questions during or after the class, feel free to ask.

All code examples and exercises can be found in the **GitHub repository** for this course.

---

## Extra Materials 📘

* https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/collections  
* https://docs.microsoft.com/en-us/dotnet/csharp/linq/
