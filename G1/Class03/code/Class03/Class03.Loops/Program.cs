

#region Loops - For
Console.WriteLine("For loop - first");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Iteration no. " + i);
}

Console.ReadLine();

Console.WriteLine("For loop - second");
for (int i = 10; i > 0; i--)
{
    Console.WriteLine("Iteration no. " + i);
}

Console.ReadLine();

// Infinit for loop
Console.WriteLine("Infinit for loop");
//for(; ; )
//{
//    Console.WriteLine("This will go on forever");
//}


// Loops indefinitely unless a condition in the block is met

for (; ; )
{
    Console.WriteLine("This will go on forever until you enter X or x!");
    string input = Console.ReadLine();
    if (input == "X" || input == "x")
        break;
}


Console.WriteLine("Creating a droid army:");
for (int i = 1; i < 10; i++)
{
    Console.WriteLine("Assemblin Droid Batalion " + i);

    // This is how you make the code execution delay for 
    // given number of miliseconds
    //Thread.Sleep(2000);

    if (i == 5)
    {
        Console.WriteLine("Problem in assembling the Droid batalion " + i);
        continue;
    }
    if (i == 7)
    {
        Console.WriteLine("Droid Assembler broke down!");
        break;
    }
    Console.WriteLine("Droid Batalion " + i + " is operational!");
}

#endregion


#region Loops - While
Console.ReadLine();

int count = 0;
Console.WriteLine("While Loop");
while (count <= 10)
{
    Console.WriteLine(count);
    count++;
}

while (true)
{
    Console.WriteLine("This will go on forever until you enter X or x!");
    string input = Console.ReadLine();
    if (input == "X" || input == "x")
        break;
}
Console.ReadLine();

// Create a droid army with while
Console.WriteLine("Creating a Clone army:");
int droidCounter = 1;
while (droidCounter <= 10)
{
    Console.WriteLine("Cloning Clone Batalion " + droidCounter);
    //Thread.Sleep(2000);
    if (droidCounter == 5)
    {
        Console.WriteLine("Problem in cloning Clone Batalion " + droidCounter);
        droidCounter++;
        continue;
    }
    if (droidCounter == 7)
    {
        Console.WriteLine("Cloning machine broke down!");
        break;
    }
    //Thread.Sleep(2000);

    Console.WriteLine("Clone Batalion " + droidCounter + " is opreational!");
    droidCounter++;
}

#endregion


#region Loops Do-While
Console.ReadLine();

int doWhileCount = 0;
Console.WriteLine("Do-While loop");
do
{
    Console.WriteLine(doWhileCount);
    doWhileCount++;
} while (doWhileCount < 10);

Console.ReadLine();

do
{
    Console.WriteLine("This will be executed once!");
} while (false);

#endregion