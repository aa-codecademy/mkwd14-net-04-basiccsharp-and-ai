var now = DateTime.Now;

Console.WriteLine($"Current date and time: {now}");
Console.WriteLine($"Three days from now: {now.AddDays(3)}");
Console.WriteLine($"One month from now: {now.AddMonths(1)}");
Console.WriteLine($"One month and three days from now: {now.AddMonths(1).AddDays(3)}");
Console.WriteLine($"One year and three months from now: {now.AddYears(1).AddMonths(3)}");
Console.WriteLine($"Current month: {now.Month}");
Console.WriteLine($"Current year: {now.Year}");