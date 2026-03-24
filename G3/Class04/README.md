# Class 04 – Methods, Strings, and DateTime 😎

**Trainer:** Risto Panchevski  <br>
Contact: risto.panchevski@gmail.com

---

## Agenda 📋

- Introduction to methods in C#
- Working with methods
- Working with strings
- Building strings and escaping characters
- Using string methods
- Working with DateTime in C#

---

## Methods

Methods in C# are basic functions. They are called methods because everything we do in C# is contained in some classes (more on this in later classes).

Methods help us:
- Organize code
- Reuse logic
- Decouple responsibilities

Because C# is a **strongly typed language**, methods require:
- Access modifier
- A method name
- Parameter types
- A defined return value (or `void` if nothing is returned)

```csharp
// The type before the name is the return type
// public and static will be discussed in next classes
public static string SayHello(string name){
  string result = $"Hello there {name}!";
  return result;
}

// Void function that does not return anything
public static void SayBye(){
  Console.WriteLine("Byeeeee!");
}
```

🤖 Let’s ask AI  
> Explain what a method is in C# and why return types are required. <br>
> Explain what a return type is in C# as if you are explaining it to someone who has never programmed before. Use a real-life example. <br>
> Why do methods in C# need a return type? What problem does this solve in a strongly typed language? <br>
> Explain the difference between a method that returns a value and a method with return type void, using simple console examples.<br>
> What happens if a method says it returns an int, but we try to return a string? Explain why this is not allowed.<br>

---

## Method Properties

- Can have access modifiers
- Can have parameters (with data types)
- Can return a value (with data type)
- If no value is returned, return type is `void`

---

## EXERCISE 1

Create **two methods**:
- `Sum` → accepts two numbers and returns their sum
- `Subtract` → accepts two numbers and returns their difference

From the console:
- Ask the user to enter `+` or `-`
- Ask the user to enter two numbers
- Call the corresponding method
- Print the result in the console

---

## Strings

Working with strings in C# can be done in different shapes and forms.  
Strings are written with `"` but can be manipulated in many ways.

---

## String Building

```csharp
string hello1 = "Hello " + name;
string hello2 = string.Format("Hello {0}", name);
string hello3 = $"Hello {name}";
```

🤖 Let’s ask AI  
> Compare string concatenation, string.Format and string interpolation and explain the for a beginner in C#.

---

## String Formatting

```csharp
// Currency formatting
string currency = string.Format("{0:C}", 125.45); 

// Percent formatting
string percent = string.Format("{0:P}", .5); 

// Custom formatting
string customFormat = string.Format("{0:0##-###-###}", 078270396); 

// Alignment formatting
string customAlignment = string.Format("| {0,10} | {1,10} |", "Id", "Order"); 
```

---

## Escaping Strings

```csharp
// Escaping with \ character
string a = "Check your c:\\ drive";
string b = "We will have \"fair\" elections";
string c = "The \\n sign means: new line";

// Escaping a whole string with @
string aa = @"Check your c:\ drive";
string bb = @"We will have ""fair"" elections";
string cc = @"The \n sign means: new line";
```

---

## EXERCISE 2

Try writing these strings in the console:
- `Check your c:\ drive`
- `We will have "fair" elections`
- `The \n sign means: new line`

---

## String Methods

```csharp
string ourString = "   We are learning C# and it is FUN and EASY. Okay, maybe just FUN.    ";
Console.WriteLine(ourString);

// Case conversion
string lower = ourString.ToLower();
string upper = ourString.ToUpper();

// Length
int ourLength = ourString.Length;

// Split
string[] splited = ourString.Split('.');
Console.WriteLine(splited[0]);
Console.WriteLine(splited[1]);
Console.WriteLine(splited[2]);

// StartsWith
bool startsWith = ourString.StartsWith("   W");

// IndexOf
int indexOfString = ourString.IndexOf("FUN");
int nonExistingString = ourString.IndexOf("Nope");

// Substring
string substring = ourString.Substring(5, 16);

// ToCharArray
char[] chars = ourString.ToCharArray();
Console.WriteLine(chars.Length);
Console.WriteLine(chars[6]);
Console.WriteLine(string.Join("", chars));
Console.WriteLine(new string(chars));

// Trim
string trimmedString = ourString.Trim();
Console.WriteLine(trimmedString);
```

🤖 Let’s ask AI  
> Which string methods in C# are most commonly used in real applications?

---

## EXERCISE 3

In the existing Console Application:
- Create a new method called `Substrings`
- Inside the method use the string:  
  `"Hello from Avenga Codecademy 2026"`
- Ask the user to enter a number `n`
- Print the first `n` characters
- Print the length of the new string
- Try to handle all scenarios

---

## DateTime

`DateTime` is a complex type in C# used for working with dates and time.

---

## Creating DateTime

```csharp
DateTime aDate = new DateTime();
DateTime aCustomDate = new DateTime(1992, 10, 15);
DateTime currentDay = DateTime.Today;
DateTime currentDateTime = DateTime.Now;
```

---

## Converting and Formatting DateTime

```csharp
string dateFormat1 = DateTime.Now.ToString("MM/dd/yyyy");
string dateFormat2 = DateTime.Now.ToString("dddd, dd MMMM yyyy");

string stringDate = "12-15-2012";
DateTime convertedDate = DateTime.Parse(stringDate);
```

---

## Manipulating DateTime

```csharp
DateTime currentDateTime = DateTime.Now;

DateTime addedDays = currentDateTime.AddDays(2);
DateTime removedDays = currentDateTime.AddDays(-5);

DateTime addedMonths = currentDateTime.AddMonths(2);
DateTime addedYears = currentDateTime.AddYears(2);
DateTime addedHours = currentDateTime.AddHours(3);

int month = currentDateTime.Month;
int day = currentDateTime.Day;
int year = currentDateTime.Year;
```

---

## EXERCISE 4

- Print the date that is **3 days from now**
- Print the date that is **1 month from now**
- Print the date that is **1 month and 3 days from now**
- Print the date **1 year and 2 months ago**
- Print **only the current month**
- Print **only the current year**

---

## Questions? ❓

If you have any questions during or after the class, feel free to ask.

All code examples and exercises can be found in the **GitHub repository** for this course.

---

## Extra Materials 📘

* https://docs.microsoft.com/en-us/dotnet/csharp/methods  
* https://www.dotnetperls.com/datetime  
* https://www.dotnetperls.com/datetime-format
