using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OnlineQuizSystemClassLibrary
{
    public class Admin : User
    {
        // Private Fields
        private DateTime loginDate;

        // Public Get/Set Constructors
        public DateTime LoginDate
        {
            get { return loginDate; }
            set { loginDate = value; }
        }

        // Default Constructor for Admin object
        public Admin()
        {
            this.id = count;
            this.Username = "";
            this.Password = "";
            this.Email = "";
            this.Role = "";
            this.LoginDate = DateTime.Now;
            count++;
        }

        // Paramaterised Constructor for Admin object
        public Admin(string userUsername, string userPassword, string userEmail, string userRole, DateTime AdminLoginDate) : base(userUsername, userPassword, userEmail, userRole)
        {
            this.id = count;
            this.LoginDate = AdminLoginDate;
            count++;
        }

        // Methods
        public void DisplayInfo()
        {
            Console.WriteLine($"Admin ID: {ID}");
            Console.WriteLine($"Admin Userame: {Username}");
            Console.WriteLine($"Admin Password: {Password}");
            Console.WriteLine($"Admin Email: {Email}");
            Console.WriteLine($"Admin Role: {Role}");
            Console.WriteLine($"Admin's Last Login Date: {LoginDate}");
            Console.WriteLine();
        }
    }
}
