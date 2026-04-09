namespace Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        //public string FullName
        //{
        //    get
        //    {
        //        return $"{FirstName} {LastName}";
        //    }
        //}
        public string Username { get; set; }
        private string Password { get; set; }
        public Role Role { get; set; }

        public User(int id, string firstName, string lastName, string username, string password, Role role)
        {
            if(string.IsNullOrEmpty(firstName)) throw new ArgumentException("First name cannot be null or empty.");
            if(string.IsNullOrEmpty(lastName)) throw new ArgumentException("Last name cannot be null or empty.");
            if(string.IsNullOrEmpty(username)) throw new ArgumentException("Username cannot be null or empty.");
            if(string.IsNullOrEmpty(password)) throw new ArgumentException("Password cannot be null or empty.");

            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Password = password;
            Role = role;
        }

        public bool ValidatePassword(string password)
        {
            return Password == password;
        }
    }
}
