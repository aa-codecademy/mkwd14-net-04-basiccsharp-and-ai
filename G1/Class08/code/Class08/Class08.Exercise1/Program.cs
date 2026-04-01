
static string SearchPhonebook(Dictionary<string, string> phoneBook, string name)
{
    if(phoneBook.TryGetValue(name, out string number))
    {
        return number;
    }
    return string.Empty;
}


Dictionary<string, string> phoneBook = new Dictionary<string, string>()
{
    { "Martin", "070222334" },
    { "Filip", "078221334" },
    { "Bob", "070222534" },
    { "Greg", "070227834" },
    { "Jill", "070249834" },
};


Console.WriteLine("Please enter name:");
string nameInput = Console.ReadLine();

string phone = SearchPhonebook(phoneBook, nameInput);
if (string.IsNullOrEmpty(phone))
{
    Console.WriteLine("No such contact");
}
else
{
    Console.Write($"Phone number: {phone}");
}
