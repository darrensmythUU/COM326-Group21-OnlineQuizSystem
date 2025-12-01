using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuizSystemClassLibrary
{
    public class Student : User
    {
        // Private Fields
        private string status;

        // Public Get/Set Constructors
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        // Default Constructor for Student object
        public Student()
        {
            this.userID = count;
            this.Username = "";
            this.Password = "";
            this.Email = "";
            this.Role = "";
            this.Status = "Inactive";
            count++;
        }

        // Paramaterised Constructor for Student object
        public Student(string userUsername, string userPassword, string userEmail, string userRole, string userStatus) : base(userUsername, userPassword, userEmail, userRole)
        {
            this.userID = count;
            this.Status = userStatus;
            count++;
        }

        // Methods
        public void DisplayInfo()
        {
            Console.WriteLine($"Student ID: {ID}");
            Console.WriteLine($"Student Username: {Username}");
            Console.WriteLine($"Student Password: {Password}");
            Console.WriteLine($"Student Email: {Email}");
            Console.WriteLine($"Student Role: {Role}");
            Console.WriteLine($"Student Status: {Status}");
            Console.WriteLine();
        }
    }
}
