# Class 09 - Error Handling and Exceptions 😮

**Trainer:** Risto Panchevski  <br>
Contact: risto.panchevski@gmail.com

---

## Agenda 📋

- Types of errors in C#
- Debugging and error handling in Visual Studio
- What are exceptions?
- Handling exceptions
- Different types of exceptions
- Practical exercise with custom validation

---

# Types of Errors

There are two main types of errors in C#:

## 1. Build Time Errors (Compile-Time)

These are errors that:
- Happen while compiling
- Are immediately visible in Visual Studio
- Prevent the code from running

Examples:
- Typo
- Type mismatch
- Missing reference
- Wrong syntax

## 2. Run Time Errors

These are errors that:
- Happen while the application is running
- Can crash the program if not handled
- Usually come from logic problems

Examples:
- Parsing wrong input
- Null reference
- Out-of-range value

🤖 Let’s ask AI  
> Explain the difference between compile-time and run-time errors in C# using simple beginner-friendly examples.

---

# Why Is Handling Errors Important?

- We don’t want to show users scary system messages.
- We don’t want our code to crash unexpectedly.
- We want to control what happens when something goes wrong.
- We want to log and track issues.

Handling errors allows:
- Code to continue running
- Friendly messages to users
- Better debugging

---

# What Are Exceptions?

Exceptions are representations of errors that happen during program execution.

They:
- Are objects
- Contain detailed information about the error
- Can be examined in Debug mode
- Can be handled in code

🤖 Let’s ask AI  
> What is an Exception object in C# and what kind of information does it contain?

---

# Handling Exceptions in C#

Handling exceptions is done using:

- try
- catch
- finally

This system prevents the application from crashing if handled properly.

---

# Try / Catch / Finally System

## Try Block

The code that may cause an exception goes here.

If an exception happens, execution jumps to the catch block.

## Catch Block

Executes only if an exception happens.

We can:
- Handle the error
- Display a message
- Log it

## Finally Block

Always executes:
- Whether there was an exception or not
- Used for cleanup operations

---

### Basic Example

```csharp
try
{
  int input = int.Parse(Console.ReadLine());
}
catch (Exception)
{
  Console.WriteLine("There was a problem!");
}
finally
{
  Console.WriteLine("Everything is done!");
}
```

---

### Catching Specific Exceptions

```csharp
try
{
  int input = int.Parse(Console.ReadLine());
}
catch (FormatException)
{
  Console.WriteLine("WRONG FORMAT! PLEASE ENTER THE RIGHT ONE!");
}
catch (Exception ex)
{
  Console.WriteLine($"ERROR: {ex.Message}");
}
finally
{
  Console.WriteLine("Everything is done!");
}
```

Exceptions are caught in order:
- First matching catch executes
- More specific exceptions should come first

🤖 Let’s ask AI  
> Why should specific exception types be placed before the general Exception catch block in C#? <br>
> Explain the precedence of exceptions and the propagation in a beginner friendly format, using diagrams or images.

---

# Exception Types

- Exception (base type – catches everything)
- FormatException
- NullReferenceException
- ArgumentException
- IndexOutOfRangeException
- And many others

We can:
- Handle all exceptions
- Or handle specific ones differently

---

# Practical Exercise – Cinema System

## Requirements

Make a class `Movie`.

Movie must have:
- Title
- Genre
- Rating
- TicketPrice

Constructor must:
- Set Title
- Set Genre
- Set Rating
- Set TicketPrice = 5 * Rating

Rating must:
- Be between 1 and 10 according to IMDB
- Throw exception if out of range
- Handle other possible exceptions

Genre must be an enum with:
- Comedy
- Horror
- Action
- Drama
- SciFi

---

Make a class `Cinema`.

Cinema must have:
- Name
- Halls
- ListOfMovies

Cinema must have method `MoviePlaying(movie)` that prints:
> Watching Movie.Title

We will provide 10 movies per cinema to put in the cinema movies list.

---

# EXERCISE 1

Make a user interface that:

1. Lets the user choose a cinema.
2. Then choose:
   - All movies
   - By genre

If "All movies":
- Show all movies
- Let user choose a movie
- Call MoviePlaying()

If "By genre":
- Ask user for favorite genre
- Show movies from that genre
- Let user choose a movie

If user enters wrong input:
- Throw an exception
- Handle all exceptions using Try/Catch

---

## Questions? ❓

If you have any questions during or after the class, feel free to ask.

All code examples and exercises can be found in the **GitHub repository** for this course.

---

## Extra Materials 📘

* https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch  
* https://stackify.com/csharp-exception-handling-best-practices/
