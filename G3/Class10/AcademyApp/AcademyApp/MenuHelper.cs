using Models;

namespace AcademyApp
{
    public static class MenuHelper
    {
        public static void DisplayAdminMenu(User loggedInUser)
        {
            Admin admin = loggedInUser as Admin;

            //Admin admin = (Admin)loggedInUser;
            //if(loggedInUser is Admin)
            //{

            //}

            Console.WriteLine($"Choose what you want to do:");
            Console.WriteLine($"1. Add new user");
            Console.WriteLine($"2. Remove user");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 2)
            {
                Console.WriteLine($"Invalid input. Please enter a number between 1 and 2.");
            }

            if (choice == 1)
            {
                Console.WriteLine($"You chose to add a new user.");

                Console.WriteLine($"In which role do you want to add the user?");
                var roles = Enum.GetValues(typeof(Role)).Cast<Role>().ToList();
                for (int i = 0; i < roles.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {roles[i]}");
                }

                int roleChoice;
                Console.Write("Enter the number corresponding to the role: ");
                while (!int.TryParse(Console.ReadLine(), out roleChoice) || roleChoice < 1 || roleChoice > roles.Count)
                {
                    Console.WriteLine($"Invalid input. Please enter a number between 1 and {roles.Count}.");
                }

                Role selectedRole = roles[roleChoice - 1];

                Console.WriteLine("Enter the first name of the user:");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter the last name of the user:");
                string lastName = Console.ReadLine();
                string username = string.Empty;
                while (true)
                {
                    Console.WriteLine("Enter the username of the user:");
                    username = Console.ReadLine();

                    if(StaticDatabase.Users.Any(u => u.Username.Equals(username)))
                    {
                        Console.WriteLine("Username already exists. Please choose a different username.");
                        continue;
                    }

                    break;
                }

                Console.WriteLine("Enter the password of the user:");
                string password = Console.ReadLine();
                List<Subject> subjects = new List<Subject>();

                if (selectedRole != Role.Admin)
                {
                    //if (selectedRole == Role.Trainer)
                    //    Console.WriteLine($"On which academy the trainer will be assigned?");
                    //if (selectedRole == Role.Student)
                    //    Console.WriteLine($"On which academy the student will be assigned?");

                    Console.WriteLine($"On which academy the {selectedRole} will be assigned?");

                    var academies = Enum.GetValues(typeof(Academy)).Cast<Academy>().ToList();
                    for (int i = 0; i < academies.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {academies[i]}");
                    }

                    int academyChoice;
                    Console.Write("Enter the number corresponding to the academy: ");
                    while (!int.TryParse(Console.ReadLine(), out academyChoice) || academyChoice < 1 || academyChoice > academies.Count)
                    {
                        Console.WriteLine($"Invalid input. Please enter a number between 1 and {academies.Count}.");
                    }

                    Academy selectedAcademy = academies[academyChoice - 1];

                    subjects = StaticDatabase.Subjects.Where(s => s.Academy == selectedAcademy).ToList();
                }

                User user = null;
                var nextId = StaticDatabase.Users.Max(u => u.Id) + 1;
                if (selectedRole == Role.Admin)
                {
                    user = new Admin(nextId, firstName, lastName, username, password);
                }
                else if (selectedRole == Role.Trainer)
                {
                    user = new Trainer(nextId, firstName, lastName, username, password, subjects);
                }
                else if (selectedRole == Role.Student)
                {
                    user = new Student(nextId, firstName, lastName, username, password, subjects);
                }

                StaticDatabase.Users.Add(user);
            }
            else if (choice == 2)
            {
                Console.WriteLine($"You chose to remove a user.");
                Console.WriteLine($"All users:");
                foreach (var user in StaticDatabase.Users)
                {
                    Console.WriteLine($"{user.Id}. {user.FullName} - {user.Role} (Username: {user.Username})");
                }

                Console.Write($"Enter the username of the user you want to remove: ");
                string usernameToRemove = Console.ReadLine();

                while (!StaticDatabase.Users.Any(u => u.Username.Equals(usernameToRemove)) || loggedInUser.Username.Equals(usernameToRemove))
                {
                    Console.WriteLine($"No user found with the username '{usernameToRemove}' or you cannot remove yourself. Please enter a valid username:");
                    usernameToRemove = Console.ReadLine();
                }

                var userToRemove = StaticDatabase.Users.First(u => u.Username.Equals(usernameToRemove));
                StaticDatabase.Users.Remove(userToRemove);
            }
        }

        public static void DisplayTrainerMenu(User loggedInUser) { }
        public static void DisplayStudentMenu(User loggedInUser) { }
    }
}
