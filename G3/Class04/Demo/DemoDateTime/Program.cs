using System.Globalization;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

DateTime date = new DateTime();
Console.WriteLine(date); // 1/1/0001 12:00:00 AM

DateTime specificTime = new DateTime(2026, 3, 23);
Console.WriteLine(specificTime); // 3/23/2026 12:00:00 AM

DateTime today = DateTime.Today;
Console.WriteLine(today); // Current date with time set to 12:00:00 AM

DateTime now = DateTime.Now;
Console.WriteLine(now); // Current date and time

DateTime yestarday = DateTime.Today.AddDays(-1);
Console.WriteLine(yestarday);
DateTime lastYear = DateTime.Today.AddYears(-1);
Console.WriteLine(lastYear);

DateTime utcNow = DateTime.UtcNow;
Console.WriteLine(utcNow); // Current date and time in UTC

Console.WriteLine(DateTime.Now.ToString("dd*MM*yyyy - hh-mm-ss"));

var culture = new CultureInfo("mk-MK");
Console.WriteLine(DateTime.Now.ToString(culture));
Console.WriteLine(DateTime.Now.ToString("dd MMMM yyyy HH:mm:ss",culture));

string input = "2026-03-23";

if (DateTime.TryParse(input, out DateTime parsedDate))
{
    Console.WriteLine($"Parsed date: {parsedDate}");
}
else
{
    Console.WriteLine("Invalid date format.");
}


Console.WriteLine($"Day of the year: {DateTime.Now.TimeOfDay}"); // 1-366