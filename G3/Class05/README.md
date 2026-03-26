# Class 05 – Classes and Objects 😍

**Trainer:** Risto Panchevski  <br>
Contact: risto.panchevski@gmail.com

---

## Agenda 📋

- Introduction to classes in C#
- Properties, methods and access modifiers
- Working with classes and objects
- Introduction to Object-Oriented Programming (OOP)

---

## C# as an Object-Oriented Language

Object-Oriented Programming is a programming paradigm focused on organizing code around real-world concepts.

C# is a **class-based object-oriented language**, meaning applications are built from objects created from classes.

🤖 Let’s ask AI  
> Explain what Object-Oriented Programming is in C# as if you are explaining it to a complete beginner, using a real-life example.

---

## Classes

Classes are templates (blueprints) used to create objects.

They:
- Contain properties (data)
- Contain methods (behavior)
- Cannot be used directly without creating objects

🤖 Let’s ask AI  
> Explain what a class is in C# using a real-life analogy like a blueprint or form.

---

## Access Modifiers

Access modifiers define who can access a class, property or method in C#.

- `public` – accessible everywhere
- `private` – accessible only inside the class
- `protected` – accessible in the class and derived classes
- `internal` – accessible only inside the same project

🤖 Let’s ask AI  
> Explain access modifiers in C# using a real-life security example.

---

## Creating a Class

```csharp
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    private long AccountNumber { get; set; }

    public void Talk(string text)
    {
        Console.WriteLine($"Human {Name} is saying {text}");
    }
}
```

🤖 Let’s ask AI  
> Walk through this Person class in C# and explain what each part does.

---

## Objects

Objects are instances of classes and represent real data created from a class template.

---

## Creating Objects

```csharp
Person bob = new Person();
bob.Name = "Bob";
bob.Age = 31;
bob.Talk("Hello!");
```

```csharp
Person anne = new Person()
{
    Name = "Anne",
    Age = 34
};
anne.Talk("Hi!");
```

🤖 Let’s ask AI  
> Explain the difference between these two ways of creating objects in C#.

---

## EXERCISE 1

Create a class **Human**.

Add properties:
- FirstName
- LastName
- Age

Create a method **GetPersonStats** that:
- Returns the full name
- Returns the age

Ask the user for input, create an object and print the result in the console.

---

## EXERCISE 2

Create a class **Dog**.

Add properties:
- Name
- Breed
- Color

Add methods:
- Eat → returns “The dog is now eating.”
- Play → returns “The dog is now playing.”
- ChaseTail → returns “The dog is now chasing its tail.”

Ask the user to:
- Enter dog data
- Choose one of the actions

Call the selected method.

---

## EXERCISE 3

Create a class **Student** with properties:
- First Name
- Last Name
- Academy
- Group

Create an array with **5 Student objects**.

Ask the user to enter a name:
- If the student exists → print the information
- If not → print an error message

---

## Questions? ❓

If you have any questions during or after the class, feel free to ask.

All code examples and exercises can be found in the **GitHub repository** for this course.

---

## Extra Materials 📘

* https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/classes  
* https://www.c-sharpcorner.com/UploadFile/mkagrahari/introduction-to-object-oriented-programming-concepts-in-C-Sharp/
