using System.Globalization;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

var name = "Risto";
var surname = "Panchevski";
var city = "Skopje";
var result = string.Format("Hello {0} {1} - {2} {2}", name, surname, city);
Console.WriteLine(result);

// Currency formatting
Console.WriteLine(string.Format("{0:C}", 125.45));
Console.WriteLine($"{125.45:C}");

// Macedonian denars formatting
var macedonianCulture = new CultureInfo("mk-MK");
Console.WriteLine(string.Format(macedonianCulture, "{0:C}", 1025.45));
Console.WriteLine($"{1025.45.ToString("C", macedonianCulture)}");


Console.WriteLine(string.Format("{0:P}", .33));
Console.WriteLine($"{0.33:P}");

Console.WriteLine(string.Format("{0:0##/###-###}", 078270396));

Console.WriteLine(string.Format("| {0,10} | {1,10} |", "Id", "Order"));

Console.WriteLine("The quote: \"To be or not to be, that is the question.\"");
Console.WriteLine("The sign \\n means new line");
Console.WriteLine("C:\\Users\\risto");
Console.WriteLine(@"C:\Users\risto");
Console.WriteLine(@"The quote: ""To be or not to be, that is the question.""");

string ourString = "   We are learning C# and it is FUN and EASY. Okay, maybe just FUN.    ";
Console.WriteLine($"Original: '{ourString}'");
Console.WriteLine($"Length: {ourString.Length}");
Console.WriteLine($"ToUpper: {ourString.ToUpper()}");
Console.WriteLine($"ToLower: {ourString.ToLower()}");
Console.WriteLine($"Trimmed: {ourString.Trim()}");
Console.WriteLine($"Substring: {ourString.Substring(3, 6)}");
var split = ourString.Trim().Split('.', StringSplitOptions.RemoveEmptyEntries);

var names = new string[] { "Aneta", "Martina", "Sejfula" };
var students = string.Join(", ", names);
Console.WriteLine($"Students: {students}");

int index = ourString.IndexOf("FUN");
Console.WriteLine($"Index of 'FUN': {index}");

int lastIndex = ourString.LastIndexOf("FUN");
Console.WriteLine($"Last index of 'FUN': {lastIndex}");

Console.WriteLine($"Checks if string is null or empty. Our string is empty: {string.IsNullOrEmpty(ourString)}");

Console.WriteLine($"Checks if string ends with 'Okay, maybe just FUN.    ': {ourString.EndsWith("Okay, maybe just FUN.    ")}");

char[] chars = ourString.ToCharArray();
foreach (var c in chars)
{
    Console.WriteLine(c);
}