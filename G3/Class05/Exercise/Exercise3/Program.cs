using Exercise3;

Student[] students = new Student[5];

for (var i = 0; i < students.Length; i++)
{
    Console.WriteLine($"Enter information for student {i + 1}:");
    Console.Write("First Name: ");
    string firstName = Console.ReadLine();
    Console.Write("Last Name: ");
    string lastName = Console.ReadLine();
    Console.Write("Academy: ");
    string academy = Console.ReadLine();
    Console.Write("Group: ");
    string group = Console.ReadLine();

    var student = new Student(firstName, lastName, academy, group);
    students[i] = student;
}

Console.WriteLine("Search a student by name:");
string searchName = Console.ReadLine();

//int foundResults = 0;
bool foundAny = false;
Console.WriteLine("Search results:"); //Risto Ristov -> Risto
foreach(var student in students)
{
    //if(student.FirstName.ToUpper().Contains(searchName.ToUpper()))
    //{
    //    Console.WriteLine(student.GetInfo());
    //    continue;
    //}

    if (student.FirstName.Contains(searchName, StringComparison.InvariantCultureIgnoreCase))
    {
        Console.WriteLine(student.GetInfo());
        //foundResults++;
        foundAny = true;
    } else if (student.LastName.Contains(searchName, StringComparison.InvariantCultureIgnoreCase))
    {
        Console.WriteLine(student.GetInfo());
        //foundResults++;
        foundAny = true;
    }

    // Alternative approach using separate if statements:
    //if (student.FirstName.Contains(searchName, StringComparison.InvariantCultureIgnoreCase))
    //{
    //    Console.WriteLine(student.GetInfo());
    //    continue;
    //}

    //if (student.LastName.Contains(searchName, StringComparison.InvariantCultureIgnoreCase))
    //{
    //    Console.WriteLine(student.GetInfo());
    //    continue;
    //}
}

//if(foundResults == 0)
//{
//    Console.WriteLine("No students found with the given name.");
//}

if(!foundAny)
{
    Console.WriteLine("No students found with the given name.");
}