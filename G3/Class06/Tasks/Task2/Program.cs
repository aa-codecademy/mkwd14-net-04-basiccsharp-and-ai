using Task2;

var users = new User[3];

users[0] = new User(1, "Alice", "password123");
users[1] = new User(2, "Bob", "securepass456");
users[2] = new User(3, "Charlie", "charlie789");

users[0].AddMessage("Hello, this is Alice!");
users[1].AddMessage("Hi, Bob here!");
users[2].AddMessage("Hey, Charlie in the house!");

users[0].AddMessage("Alice's second message.");
users[1].AddMessage("Bob's second message.");
users[2].AddMessage("Charlie's second message.");

users[0].AddMessage("Alice's third message.");

var infiniteLoop = true;
while (infiniteLoop)
{
    Console.WriteLine("Select one option: ");
    Console.WriteLine("1. Login");
    Console.WriteLine("2. Register");
    Console.WriteLine("3. Exit");
    var input = Console.ReadLine();
    
    switch (input)
    {
        case "1":
            Login(users);
            break;
        case "2":
            users = Register(users);
            break;
        case "3":
            infiniteLoop = false;
            break;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
}

static void Login(User[] users)
{
    Console.Write("Enter username: ");
    var username = Console.ReadLine();

    Console.Write("Enter password: ");
    var password = Console.ReadLine();

    User loggedInUser = null;

    foreach(var user in users)
    {
        if (user.Username == username && user.PasswordMatches(password))
        {
            loggedInUser = user;
            break;
        }
    }

    if (loggedInUser == null)
    {
        foreach (var user in users)
        {
            if (user.Username == username)
            {
                Console.WriteLine("Incorrect password.");
                return;
            }
        }

        Console.WriteLine("User not found.");
    }
    else
    {
        Console.WriteLine($"Welcome {loggedInUser.Username}. Here are your messages:");
        foreach(var message in loggedInUser.Messages)
        {
            Console.WriteLine($"\t - {message}");
        }
    }
}

static User[] Register(User[] users)
{
    Console.WriteLine("Enter username: ");
    var username = Console.ReadLine();

    Console.WriteLine("Enter password: ");
    var password = Console.ReadLine();

    foreach(var user in users)
    {
        if(user.Username == username)
        {
            Console.WriteLine("Username already exists. Please choose a different username, or login with that username.");
            return users;
        }
    }

    var id = users[users.Length - 1].Id + 1;
    var newUser = new User(id, username, password);

    while(true)
    {
        Console.WriteLine("Enter a message to add to your account (or type 'X' to finish): ");
        var message = Console.ReadLine();

        if (message.ToUpper() == "X")
        {
            break;
        }

        newUser.AddMessage(message);
    }

    Array.Resize(ref users, users.Length + 1);
    users[users.Length - 1] = newUser;

    return users;
}