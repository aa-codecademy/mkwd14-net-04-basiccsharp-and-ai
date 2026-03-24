// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(SayHello("Risto"));
SayHello2("Risto");

static string SayHello(string name)
{
    string result = $"Hello there {name}!";
    return result;
}

static void SayHello2(string name)
{
    string result = $"Hello there {name}!";
    Console.WriteLine(result);
}
