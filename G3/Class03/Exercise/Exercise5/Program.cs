string[] names = new string[0];

while (true)
{
    Console.WriteLine("Please enter a name:");
    string inputName = Console.ReadLine();

    Array.Resize(ref names, names.Length + 1);
    names[names.Length - 1] = inputName;

    bool proceed = false;
    while (true)
    {
        Console.WriteLine("Do you want to enter another name? (Y/N)");
        string inputChoice = Console.ReadLine().ToUpper();

        if (inputChoice != "N" && inputChoice != "Y")
        {
            Console.WriteLine("Please enter a valid choice (Y/N)");
            continue;
        }
        else if (inputChoice == "N")
        {
            proceed = false;
            break;
        }
        else if (inputChoice == "Y")
        {
            proceed = true;
            break;
        }
    }

    if (proceed)
    {
        continue;
    }
    else
    {
        Console.WriteLine("The names you entered are:");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
        break;
    }
}