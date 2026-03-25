namespace Class05.Classes.Models
{
    internal class Student
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public Group Group { get; set; }

        public Student(string fullName, int age, Group group)
        {
            FullName = fullName;
            Age = age;
            // The same as the following if/else but using null coalescing  
            Group = group ?? new Group("Unknown", 0, "Unknown");

            //if(group != null)
            //{
            //    Group = group;
            //}
            //else
            //{
            //    Group = new Group("Unknown", 0, "Unknown");
            //}
        }

        public void DisplaStudentInfo()
        {
            Console.WriteLine($"{FullName} from group {Group.GroupName}");
        }
    }
}
