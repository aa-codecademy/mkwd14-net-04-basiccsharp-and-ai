namespace Class05.Classes.Models
{
    internal class Group
    {
        public string GroupName { get; set; }
        public int NumberOfStudents { get; set; }
        public string CurrentSubjectName { get; set; }


        public Group()
        {
            
        }

        public Group(string groupName, int numOfStudents, string currentSubjectName)
        {
            GroupName = groupName;
            NumberOfStudents = numOfStudents;
            CurrentSubjectName = currentSubjectName;
        }

        public void DisplayGroupInfo()
        {
            Console.WriteLine($"This is group {GroupName} with {NumberOfStudents} students.");
        }
    }
}
