


#region Exceptions and Exception Handling

// Handling .net exception
using Class09.Exceptions.Models;

Console.WriteLine("-------------------------- Example 1 -------------------------");

try
{
    Console.WriteLine("Enter a number:");
    int number = Int32.Parse(Console.ReadLine());
    Console.WriteLine($"The number you entered is: {number}");
}
catch (Exception ex)
{
    Console.WriteLine("Ooops, something went wrong! Please try again later");
    Console.WriteLine("---------------------------------------------------");
    Console.WriteLine($"Info for developer: {ex.Message}");
    Console.WriteLine($"{ex.StackTrace}");
}
finally
{
    Console.WriteLine("--------- Press any key to continue -----------");
    Console.ReadLine();
}


// Custom Exception (Exception with our own logic)
Console.WriteLine("-------------------------- Example 2 -------------------------");
Console.WriteLine("Handling exception with custom message");
try
{
    Console.WriteLine("Enter letter a or letter b:");
    string letter = Console.ReadLine().Trim().ToLower();
    if (letter == "a" || letter == "b")
    {
        Console.WriteLine("Congratulations, you have entered a or b!");
    }
    else
    {
        throw new Exception("That is not a or b! Sorry!", new Exception($"Incorrect input '{letter}'."));
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("More info:" + ex.InnerException);
}
finally
{
    Console.WriteLine("--------- Press any key to continue -----------");
    Console.ReadLine();
}




#endregion


#region Handling specific exceptions
Console.WriteLine("-------------------------- Example 3 -------------------------");

try
{
    Console.WriteLine("Enter some character");
    char char1 = char.Parse(Console.ReadLine());
    Console.WriteLine($"The character you entered is: {char1}");

    Console.WriteLine("Please enter a number:");
    int number1 = Int32.Parse(Console.ReadLine());
    Console.WriteLine($"The number you entered is: {number1}");

    Person p = new Person() { Name = "Martin" };
    foreach (var skill in p.Skills)
    {
        Console.WriteLine(skill);
    }
}
catch (FormatException frmEx)
{
    Console.WriteLine("You have entered somthing other than a charachter!");
}
catch(OverflowException ovEx)
{
    Console.WriteLine("You have entered either too large or too small number for integer!");
}
catch(Exception ex)
{
    Console.WriteLine("Somthing went wrong!");
}
finally
{
    Console.WriteLine("--------- Press any key to continue -----------");
    Console.ReadLine();
}

#endregion

#region Handling exceptions within a method

//Exception handling propagation (exception sent to the higher level)
static void PersonSkill1(Person person)
{
    foreach (var skill in person.Skills)
    {
        Console.WriteLine(skill);
    }
}

static void PersonSkill2(Person person)
{
    try
    {
        foreach (var skill in person.Skills)
        {
            Console.WriteLine(skill);
        }
    }
    catch (Exception ex) 
    {
        Console.WriteLine($"Catch inside the fundion: {ex.Message}");
    }
}


try
{
    PersonSkill1(new Person() { Name = "Mario" });
    PersonSkill2(new Person() { Name = "Klementina" });
}
catch (NullReferenceException ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("--------- Press any key to continue -----------");
    Console.ReadLine();
}

#endregion