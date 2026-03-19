Console.WriteLine("How many trees you have?");
var input = Console.ReadLine();

int numberOfTrees;
bool isValidInput = int.TryParse(input, out numberOfTrees);

if (!isValidInput)
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
    return;
}

Console.WriteLine("How many branches are per tree?");
if(!int.TryParse(Console.ReadLine(), out int branchesPerTree))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
    return;
}

Console.WriteLine("How many apples are per branch?");
if (!int.TryParse(Console.ReadLine(), out int applesPerBranch))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
    return;
}

Console.WriteLine("How many apples per baskets?");
if (!int.TryParse(Console.ReadLine(), out int applesPerBaskets))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
    return;
}

int totalApples = numberOfTrees * branchesPerTree * applesPerBranch;
int result = totalApples / applesPerBaskets;

if(totalApples % applesPerBaskets != 0)
{
    result += 1; // If there are remaining apples, we need an additional basket
}

Console.WriteLine($"You need {result} baskets.");
