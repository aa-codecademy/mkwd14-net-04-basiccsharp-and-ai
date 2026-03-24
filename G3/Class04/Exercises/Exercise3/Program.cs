string text = "Hello from Avenga Codecademy 2026";

Console.WriteLine("Please enter a position from which to extract a substring:");

int position;
while (!int.TryParse(Console.ReadLine(), out position) || position < 1 || position > text.Length)
{
    Console.WriteLine("Invalid input. Please enter a valid position (1 to {0}):", text.Length);
}

Console.WriteLine("Extracted substring: " + Substrings(text, position));

static string Substrings(string text, int position)
{
    return text.Substring(position - 1);
}
