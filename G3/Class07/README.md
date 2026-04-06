# Class 07 - Constructors, Enums, Class Libraries, and Inheritance 😜

**Trainer:** Ilija Mitev  <br>
Contact: ilija.mitev3@gmail.com  
 

---

## Agenda 📋

- Class based inheritance in C#
- What are enumerations
- Class library project
- Constructors in C#
- Overriding methods

---

# CONCEPT OF INHERITANCE

Inheritance is one of the main pillars of object oriented programming.

This means that an entity can inherit some properties or methods from another entity.

There are different types of inheritance:
- Prototype based
- Class based

C# uses **class-based inheritance**.

🤖 Let’s ask AI  
> Explain inheritance as if you are explaining it to a beginner, using a real-life example.

---

## BENEFITS OF INHERITANCE

- We can reuse common properties or methods
- We can organize entities in an inheritance tree (general → specific)
- Multiple entities can inherit from the same base class
- We can create inheritance chains
- In some languages multiple inheritance is allowed (not in C# for classes)

---

## INHERITANCE IN C#

Inheritance in C# follows these rules:

- A class can inherit from only **one** class
- A class can inherit from a class that inherits from another class
- A child class can override parent methods
- Constructors can be chained

🤖 Let’s ask AI  
> Why does C# allow only single class inheritance? What problems does that prevent?

---

# Constructors

Constructors are special methods that execute when an object is created.

Key rules in C#:
- Constructor name is the same as the class
- Constructors have no return type
- We can overload constructors
- They are used to initialize data

```csharp
public class Person
{
  public string Name { get; set; }
  public string Age { get; set; }
  private long AccountNumber { get; set; }

  public Person()
  {
    AccountNumber = 34235432452;
  }

  public Person(string name, int age)
  {
    Name = name;
    Age = age;
    AccountNumber = 25325325221;
  }

  public void Talk(string text)
  {
    Console.WriteLine($"Human {Name} is saying {text}");
  }
}
```

---

### Constructing objects

```csharp
Person george = new Person();
Person bill = new Person("Bill", 25);
bill.Talk("Hello!");
```

🤖 Let’s ask AI  
> Explain constructor overloading in C# step by step with a simple example.

---

# WHAT ARE ENUMERATIONS?

Enumerations are sets of predefined integer values.

They:
- Cannot change at runtime
- Cannot hold methods
- Cannot inherit from other classes
- Are defined with the `enum` keyword

We use them for:
- Days of week
- Months
- Statuses
- Roles
- Application states

```csharp
public enum Days
{
  Monday,
  Tuesday,
  Wednesday,
  Thursday,
  Friday,
  Saturday,
  Sunday
}
```

---

### Using enums

```csharp
if (today == Days.Friday)
{
  Console.WriteLine("PARTY");
}
```

🤖 Let’s ask AI  
> Explain what enums are in C# and why they are safer than using plain strings for statuses for example.

---

# CLASS LIBRARY PROJECT

A class library is a collection of classes stored in a separate project.

It:
- Cannot be executed directly
- Is referenced from other projects
- Helps separate logic
- Encourages reuse

To use a class library:
- Add project reference
- Add `using` statement

Class libraries usually hold:
- Domain classes
- Service classes

🤖 Let’s ask AI  
> Explain why we would separate domain classes into a Class Library project in C#.

---

# Overriding Methods

Parent class:

```csharp
public class Human
{
    public string Name { get; set; }
    public int Age { get; set; }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"This is {Name} and it's of the age of {Age}.");
    }
}
```

Child class:

```csharp
public class Programmer : Human
{
    public string[] ProgrammingLanguages { get; set; }

    public void DevelopApp()
    {
        Console.WriteLine($"The programmer {Name} is developing an app...");
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"This is {Name} and these are the programming languages they know:");
        foreach (string language in ProgrammingLanguages)
        {
            Console.WriteLine(language);
        }
    }
}
```

🤖 Let’s ask AI  
> Explain the difference between virtual and override in C# using a beginner-friendly explanation. <br>
> Why would we use overriding of methods in C#. Please explain in a beginner friendly manner.

---

# EXERCISE – Base Setup

Create a class library project.

Inside it create:

Class `Employee` with properties:
- FirstName
- LastName
- Role (Enum: Sales, Manager, Other)
- Salary (protected double)

Methods:
- PrintInfo()
- GetSalary()

---

# EXERCISE 1

Create a `SalesPerson` class that inherits from Employee.

Properties:
- SuccessSaleRevenue (double, private)

Rules:
- Default salary = 500
- Default role = Sales

Create:
- Constructor that sets all properties
- Method AddSuccessRevenue(number)

Override GetSalary():
- If revenue ≤ 2000 → +500 bonus
- If revenue ≤ 5000 → +1000 bonus
- If revenue > 5000 → +1500 bonus

---

# EXERCISE 2

Create class `Manager` that inherits from Employee.

Property:
- Bonus (double, private)

Create:
- Constructor
- Method AddBonus()

Override GetSalary() to return Salary + Bonus.

---

## Questions? ❓

If you have any questions during or after the class, feel free to ask.

All code examples and exercises can be found in the **GitHub repository** for this course.

---

## Extra Materials 📘

* https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constructors  
* https://www.dotnetperls.com/enum  
* https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/inheritance  
* https://www.dotnetperls.com/override
