using Class05.Classes.Models;


#region Classes definition and creating instance objects


// Create a Person object using the parametereless constructor and set properties manually
Person martin = new Person();
martin.FirstName = "Martin";
martin.LastName = "Panovski";
martin.Age = 32;
martin.Hobbies = ["Reading books", "Running"];
martin.IsStudent = false;


Console.WriteLine($"{martin.FirstName} {martin.LastName} - {martin.GetSSNValue()}");
Console.ReadLine();


// Create a Person object using the object initializer syntax.
Person bob = new Person()
{
    FirstName = "Bob",
    LastName = "Bobsky",
    Age = 25,
    PhoneNumber = "070/222-333",
    Hobbies = ["Running", "Listening to musing"],
    IsStudent = true,
};


Console.WriteLine($"{bob.FirstName} {bob.LastName} - {bob.GetSSNValue()} is {bob.Age} years old.");
Console.ReadLine();



Person jill = new Person("Jill", "Wayne", "070/123-456", 28, [], true);

Console.WriteLine($"{jill.FirstName} {jill.LastName} - {jill.GetSSNValue()} is {jill.Age} yers old.");


jill.Talk("Hello there nice to meet you!");

#endregion



#region Working with classes

Group g1 = new Group("G1", 12, "Basic C#");
Group g2 = new Group("G2", 18, "Web development using NodeJS");


Student mario = new Student("Mario Simonovski", 34, g1);
Student dimitar = new Student("Dimitar Kocevski", 19, g1);

Student tomi = new Student("Tomi Tomi", 36, g2);

Student ivo = new Student("Ivo Kostovski", 36, new Group("G3", 10, "HTML/CSS"));
Student cvetko = new Student("Cvetko Cvetkovski", 35, new Group()
{
    GroupName = "G3",
    CurrentSubjectName = "HTML/CSS",
    NumberOfStudents = 10
});


mario.DisplaStudentInfo();
dimitar.DisplaStudentInfo();

tomi.DisplaStudentInfo();

ivo.DisplaStudentInfo();
cvetko.DisplaStudentInfo();


Student filip = new Student("Filip Mihajlovski", 27, null);
filip.DisplaStudentInfo();

#endregion