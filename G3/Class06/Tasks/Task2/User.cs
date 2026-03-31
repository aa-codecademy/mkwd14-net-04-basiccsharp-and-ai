namespace Task2
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        private string Password { get; set; }
        public string[] Messages { get; set; } = [];

        public User(int id, string username, string password)
        {
            Id = id;
            Username = username;
            Password = password;
        }

        public void AddMessage(string message) { 
            var array = new string[Messages.Length + 1];
            for (int i = 0; i < Messages.Length; i++)
            {
                array[i] = Messages[i];
            }

            array[Messages.Length] = message;
            Messages = array;
        }

        public bool PasswordMatches(string password)
        {
            return Password == password;
        }
    }
}
