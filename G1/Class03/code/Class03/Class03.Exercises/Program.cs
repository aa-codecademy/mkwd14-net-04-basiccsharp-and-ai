#region Exercise 1
Console.Write("Enter an integer: ");
int input = int.Parse(Console.ReadLine());


// 1) Print all numbers from 1 up to that number
Console.Write("1 up to " + input + ": ");
for (int i = 1; i <= input; i++)
{
    Console.Write(i + " ");
}
Console.WriteLine();

// 2) Print all numbers starting from that number down to 1
Console.Write(input + " down to 1: ");
for (int i = input; i >= 1; i--)
{
    Console.Write(i + " ");
}
Console.WriteLine();

// 3) Print all even numbers starting from 2
Console.Write("Even numbers (starting from 2): ");
for (int i = 2; i <= input; i += 2)
{
    Console.Write(i + " ");
}
Console.WriteLine();

// 4) Print all odd numbers starting from 1
Console.Write("Odd numbers (starting from 1): ");
for (int i = 1; i <= input; i += 2)
{
    Console.Write(i + " ");
}
#endregion

Console.ReadLine();

#region Exercise 2
Console.Write("Enter an integer: ");
int userInput = int.Parse(Console.ReadLine());

int j = 1;
while (j <= userInput)
{
    if (j == 100)
    {
        Console.WriteLine("The limit is reached");
        break;
    }

    if (j % 3 == 0 || j % 7 == 0)
    {
        j++;
        continue;
    }

    Console.Write(j + " ");
    j++;
}
#endregion