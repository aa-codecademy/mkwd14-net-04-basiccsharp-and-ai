
using Class08.LINQ.Models;

var students = new List<Student>
{
    new Student(1, "John",  "Doe",    22, "G1", Academy.WebDev,   new List<string>{ "BasicCSharp", "AdvancedCSharp" }),
    new Student(2, "Maria", "Smith",  24, "G2", Academy.FrontEnd, new List<string>{ "HTML/CSS", "JS" }),
    new Student(3, "Ana",   "Johnson",21, "G3", Academy.Design,   new List<string>{ "Figma", "Photoshop" }),
    new Student(4, "Mark",  "Brown",  26, "G1", Academy.WebDev,   new List<string>{ "BasicJS", "AJS" }),
    new Student(5, "Lisa",  "White",  23, "G4", Academy.FrontEnd, new List<string>{ "HTML/CSS", "Figma" }),
    new Student(6, "Tom",   "Harris", 20, "G2", Academy.Design,   new List<string>{ "Basic HTML/CSS", "Figma" }),
    new Student(7, "Eva",   "Green",  25, "G3", Academy.WebDev,   new List<string>{ "BasicCSharp", "BasicJS" }),
    new Student(8, "Paul",  "Black",  22, "G4", Academy.FrontEnd, new List<string>{ "JS" }),
    new Student(9, "Nina",  "Blue",   27, "G1", Academy.Design,   new List<string>{ "Photoshop", "Basic HTML/CSS" }),
    new Student(10,"Alex",  "Gray",   19, "G2", Academy.WebDev,   new List<string>{ "AdvancedCSharp", "AJS" })
};


// First()
// Where()
Student lisa = students
                .Where(x => x.FirstName == "Lisa")
                .First();
Console.WriteLine($"{lisa.FirstName} {lisa.LastName} - {lisa.Academy.ToString()}");


// ToList()
var allWebDevStudentsFromG1 = students
                                .Where(x => x.Academy == Academy.WebDev && x.Group == "G1")
                                .ToList();
foreach (var std in allWebDevStudentsFromG1)
{
    Console.WriteLine($"" +
        $"{std.FirstName} {std.LastName} - " +
        $"Academy: {std.Academy.ToString()} " +
        $"Group: {std.Group}");
}


// Last()
var lastStudent = students.Last();
Console.WriteLine($"{lastStudent.FirstName} {lastStudent.LastName}");


// Select()
var marksSubjects = students
    .Where(x => x.FirstName == "Mark")
    .Select(x => x.Subjects)
    .First();
foreach (var sub in marksSubjects)
{
    Console.WriteLine(sub);
}

var customSelection = students
    .Where(x => x.FirstName == "Martin")
    .Select(x => new
    {
        FullName = $"{x.FirstName} {x.LastName}",
        Subjects = x.Subjects
    })
    .FirstOrDefault();

Console.WriteLine(customSelection.FullName);
foreach (var sub in customSelection.Subjects)
{
    Console.WriteLine(sub);
}