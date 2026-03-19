int[] arrayOfNumbers = new int[5];

for( var i = 0; i < arrayOfNumbers.Length; i++)
{
    Console.WriteLine($"Please enter number {i + 1}:");
    if (!int.TryParse(Console.ReadLine(), out int inputNumber))
    {
        Console.WriteLine("Please enter a valid number");
        i--;
        continue;
    }

    arrayOfNumbers[i] = inputNumber;
}

int sum = 0;
foreach (var number in arrayOfNumbers)
{
    sum += number;
}

//int sumUsingLinq = arrayOfNumbers.Sum();

Console.WriteLine($"The sum of the numbers is: {sum}");