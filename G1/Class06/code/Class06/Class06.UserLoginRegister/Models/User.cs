namespace Class06.UserLoginRegister.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string[] Messages { get; set; }

        public User(int id, string username, string password, string[] messages)
        {
            Id = id;
            Username = username;
            Password = password;
            Messages = messages ?? new string[0];
        }
    }
}
