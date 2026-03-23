
#region Working with Dates

// Creating an empty DateTime
using System.Globalization;

DateTime date = new DateTime();
Console.WriteLine(date);


// Creating a custom date YEAR MONTH DAY

DateTime customDate = new DateTime(1993, 08, 27, 11, 20, 35);
Console.WriteLine(customDate);


// Coverting from string to DateTime
// Variations

string stringDateFirst = "15.12.2015";
string stringDateSecond = "15/12/2015";
string stringDateThird = "15/12/15";
string stringDateFourth = "dec.15.15";
string stringdateFifth = "15-12-15";

DateTime stringDate = DateTime.Parse(stringDateFirst);
Console.WriteLine(stringDate);

DateTime today = DateTime.Now;
Console.WriteLine(today);

Console.WriteLine(today.AddDays(2));
Console.WriteLine(today.AddDays(-2));

Console.WriteLine(today.Day);
Console.WriteLine(today.Date);
Console.WriteLine(today.DayOfWeek);
Console.WriteLine(today.Month);


string dateFormat1 = today.ToString("MM/dd/yyyy");

// If you end up with ??????? in the console it is because of your PC 
// Time format setting. Change Clock and Region in control panel to be en-US format
string dateFormat2 = today.ToString("dddd, dd MMMM yyyy", CultureInfo.GetCultureInfo("en-US"));
Console.WriteLine(dateFormat1);
Console.WriteLine(dateFormat2);


string dateFormat3 = string.Format("Today is {0:MM/dd/yy}, {0:dddd}", today);
Console.WriteLine(dateFormat3);



#endregion