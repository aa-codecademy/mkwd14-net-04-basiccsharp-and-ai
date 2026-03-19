Console.WriteLine("(Part 1)Please enter a number:");
if(!int.TryParse(Console.ReadLine(), out int number1))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
    return;
}

for (int i = 1; i <= number1; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("(Part 2) Please enter a number:");
if (!int.TryParse(Console.ReadLine(), out int number2))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
    return;
}

for(int i = number2; i >= 1; i--)
{
    Console.WriteLine(i);
}

Console.WriteLine("(Part 3) Please enter a number:");
if (!int.TryParse(Console.ReadLine(), out int number3))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
    return;
}

var j = 1;
while(j <= number3)
{
    if(j % 2 == 0)
    { 
        Console.WriteLine(j);
    }

    j++;
}

Console.WriteLine("(Part 4) Please enter a number:");
if (!int.TryParse(Console.ReadLine(), out int number4))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
    return;
}

//var k = 1;
//while (k <= number4)
//{
//    if (k % 2 == 1)
//    {
//        Console.WriteLine(k);
//    }

//    k++;
//}

var k = 1;
while (k <= number4)
{
    Console.WriteLine(k);
    k += 2;
}