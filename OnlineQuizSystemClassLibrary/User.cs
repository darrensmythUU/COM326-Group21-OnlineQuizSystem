namespace OnlineQuizSystemClassLibrary
{
    public class User
    {
        // Private Fields
        private int id;
        private string username;
        private string password;
        private string email;
        private string role;

        // Get/Set Constructors
        public int ID
        {
            get { return id; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        // Constructor for User object
        public User(string userUsername, string userPassword, string userEmail, string userRole)
        {
            this.Username = userUsername;
            this.Password = userPassword;
            this.Email = userEmail;
            this.Email = userRole;
        }

        // Methods
    }
}
