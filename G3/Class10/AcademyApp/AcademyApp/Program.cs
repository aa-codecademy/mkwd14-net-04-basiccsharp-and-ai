// See https://aka.ms/new-console-template for more information
using AcademyApp;
using Models;

try
{
    while (true)
    {
        Console.WriteLine("Welcome to Avenga Academy, please Login!");
        User loggedInUser = null;

        while (true)
        {
            Console.Write("Username: ");
            string username = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            var user = StaticDatabase.Users.FirstOrDefault(x => x.Username == username);
            //var user = StaticDatabase.Users.FirstOrDefault(x => x.Username == username && x.ValidatePassword(password));

            if (user == null)
            {
                Console.WriteLine("User not found, please try again.");
                continue;
            }

            if (!user.ValidatePassword(password))
            {
                Console.WriteLine("Wrong password, please try again.");
                continue;
            }

            loggedInUser = user;
            break;
        }

        Console.WriteLine($"Welcome, {loggedInUser.FullName}! You are logged in as {loggedInUser.Role}.");

        while (true)
        {
            switch (loggedInUser.Role)
            {
                case Role.Admin:
                    MenuHelper.DisplayAdminMenu(loggedInUser);
                    break;
                case Role.Trainer:
                    MenuHelper.DisplayTrainerMenu(loggedInUser);
                    break;
                case Role.Student:
                    MenuHelper.DisplayStudentMenu(loggedInUser);
                    break;
                default:
                    Console.WriteLine("Unknown role, access denied.");
                    break;
            }

            Console.WriteLine("If you want to logout, type 'y' and press Enter, or type any other key to proceed with another action.");
            string logoutChoice = Console.ReadLine();
            if (logoutChoice.Equals("y", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}