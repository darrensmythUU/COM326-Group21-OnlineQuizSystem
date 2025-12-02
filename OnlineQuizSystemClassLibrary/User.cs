namespace OnlineQuizSystemClassLibrary
{
    public class User
    {
        // Private Fields
        protected int userID;
        private string username;
        private string password;
        private string email;
        private string role;
        protected static int count = 0;

        // Public Get/Set Constructors
        public int ID
        {
            get { return userID; }
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

        // Default Constructor for User object
        public User()
        {
            this.userID = count;
            this.Username = "";
            this.Password = "";
            this.Email = "";
            this.Email = "";
            count++;
        }

        // Paramaterised Constructor for User object
        public User(string userUsername, string userPassword, string userEmail, string userRole)
        {
            this.userID = count;
            this.Username = userUsername;
            this.Password = userPassword;
            this.Email = userEmail;
            this.Email = userRole;
            count++;
        }

        // Methods
    }
}
