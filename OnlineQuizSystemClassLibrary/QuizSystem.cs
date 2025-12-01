using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuizSystemClassLibrary
{
    public class QuizSystem
    {
        // Private Fields
        private List<User> users;
        private List<Quiz> quizzes;
        private List<Category> categories;
        private List<Question> questionBank;

        // Public Get/Set Constructors
        public List<User> Users
        {
            get { return users; }
            set { users = value; }
        }

        public List<Quiz> Quizzes
        {
            get { return quizzes; }
            set { quizzes = value; }
        }

        public List<Category> Categories
        {
            get { return categories; }
            set { categories = value; }
        }

        public List<Question> QuestionBank
        {
            get { return questionBank; }
            set { questionBank = value; }
        }

        // Default Constructor for QuizSystem object
        public QuizSystem()
        {
            this.Users = new List<User>();
            this.Quizzes = new List<Quiz>();
            this.Categories = new List<Category>();
            this.QuestionBank = new List<Question>();
        }

        // Paramaterised Constructor for QuizSystem object
        public QuizSystem(List<User> users, List<Quiz> quizzes, List<Category> categories, List<Question> questionBank)
        {
            this.Users = users;
            this.Quizzes = quizzes;
            this.Categories = categories;
            this.QuestionBank = questionBank;
        }

        // Methods
        public void LoadSampleData()
        {
            // Admin List
            List<Admin> admins = new List<Admin>()
            {
                new Admin("adminAlpha", "AdmA!123", "alpha.admin@mail.com", "Admin", new DateTime(2025, 11, 27)),
                new Admin("adminBravo", "Br@vo567", "bravo.admin@mail.com", "Admin", new DateTime(2025, 11, 28)),
                new Admin("adminCharlie", "Ch#r901", "charlie.admin@mail.com", "Admin", new DateTime(2025, 11, 29)),
                new Admin("adminDelta", "Delt@222", "delta.admin@mail.com", "Admin", new DateTime(2025, 11, 30)),
                new Admin("adminEcho", "Echo!888", "echo.admin@mail.com", "Admin", new DateTime(2025, 12, 1)),
                new Admin("adminFoxtrot", "F0xPwd42", "foxtrot.admin@mail.com", "Admin", new DateTime(2025, 11, 27)),
                new Admin("adminGolf", "G0lf#77", "golf.admin@mail.com", "Admin", new DateTime(2025, 11, 28)),
                new Admin("adminHotel", "HtL!555", "hotel.admin@mail.com", "Admin", new DateTime(2025, 11, 30)),
                new Admin("adminIndia", "Ind!a333", "india.admin@mail.com", "Admin", new DateTime(2025, 12, 1)),
                new Admin("adminJuliet", "Jul#900", "juliet.admin@mail.com", "Admin", new DateTime(2025, 11, 29))
            };

            // Student List
            List<Student> students = new List<Student>()
            {
                new Student("studA", "A1a!pass", "studA@mail.com", "Student", "Active"),
                new Student("studB", "B1b@pass", "studB@mail.com", "Student", "Inactive"),
                new Student("studC", "C1c#pass", "studC@mail.com", "Student", "Active"),
                new Student("studD", "D1d$pass", "studD@mail.com", "Student", "Inactive"),
                new Student("studE", "E1e%pass", "studE@mail.com", "Student", "Active"),
                new Student("studF", "F1f^pass", "studF@mail.com", "Student", "Inactive"),
                new Student("studG", "G1g&pass", "studG@mail.com", "Student", "Active"),
                new Student("studH", "H1h*pass", "studH@mail.com", "Student", "Inactive"),
                new Student("studI", "I1i(pass)", "studI@mail.com", "Student", "Active"),
                new Student("studJ", "J1j_pass", "studJ@mail.com", "Student", "Inactive")
            };

            // Category List
            List<Category> categories = new List<Category>()
            {
                new Category("Programming", "Concepts of object-oriented programming and coding principles"),
                new Category("Data Structures", "Arrays, lists, stacks, queues, trees, and their applications"),
                new Category("Software Design", "Design patterns, architecture principles, and system modelling"),
                new Category("Web Development", "HTML, CSS, JavaScript, and client-server interactions"),
                new Category("Database Systems", "SQL queries, relational models, normalization, and transactions"),
                new Category("Cybersecurity Basics", "Encryption, authentication, and common security threats"),
                new Category("Computer Networks", "Protocols, IP addressing, routing, and network layers")
            };

            // Quiz List
            List<Quiz> quizzes = new List<Quiz>()
            {
                new Quiz("OOP Fundamentals", "Covers basics of object-oriented programming", "Programming", "List of 10 OOP-related questions", new DateTime(2025, 09, 01)),
                new Quiz("Data Structures", "Focuses on arrays, lists, stacks, queues, trees, and their applications.", "Programming", "List of 10 OOP-related questions", new DateTime(2025, 09, 01)),
                new Quiz("Software Design", "Includes design patterns, architecture principles, and system modelling.", "Software Design", "List of 10 OOP-related questions", new DateTime(2025, 09, 01)),
                new Quiz("Web Development", "HTML, CSS, JavaScript, and client-server interactions", "Web Development", "List of 10 OOP-related questions", new DateTime(2025, 09, 07)),
                new Quiz("Database Systems", "SQL queries, relational models, normalization, and transactions.", "Database Systems", "List of 10 OOP-related questions", new DateTime(2025, 09, 07)),
                new Quiz("Cybersecurity Basics", "Encryption, authentication, and common security threats", "Cybersecurity Basics", "List of 10 OOP-related questions", new DateTime(2025, 09, 11)),
                new Quiz("Computer Networks", "Protocols, IP addressing, routing, and network layers", "Computer Networks", "List of 10 OOP-related questions", new DateTime(2025, 09, 13))
            };

            // Question List
            List<Question> questions = new List<Question>()
            {
                new Question("What does OOP stand for?", new List<string>() { "Object-Oriented Programming", "Operational Output" }, "Object-Oriented Programming", "Easy"),
                new Question("Which of the following is NOT a core principle of OOP?", new List<string>() { "Encapsulation", "Polymorphism", "Abstraction", "Compilation" }, "Compilation", "Easy"),
                new Question("What is encapsulation in object-oriented programming?", new List<string>() { "Binding data and methods", "Inheritance", "Overloading", "Creating objects" }, "Binding data and methods", "Medium"),
                new Question("Which keyword is used in C# to inherit a class?", new List<string>() { "extends", "inherits", ":", "base" }, ":", "Medium"),
                new Question("What is the purpose of a constructor in a class?", new List<string>() { "To destroy objects", "To initialize objects", "To inherit methods", "To override properties" }, "To initialize objects", "Easy"),
                new Question("Which concept allows multiple methods with the same name but different parameters?", new List<string>() { "Inheritance", "Polymorphism", "Overloading", "Encapsulation" }, "Overloading", "Medium"),
                new Question("What is the base class for all classes in C#?", new List<string>() { "System.Object", "BaseClass", "RootClass", "MainClass" }, "System.Object", "Hard"),
                new Question("What is the difference between a class and an object?", new List<string>() { "Class is an instance, object is a blueprint", "Class is a blueprint, object is an instance", "They are the same", "Object inherits class" }, "Class is a blueprint, object is an instance", "Medium"),
                new Question("Which access modifier makes a member accessible only within its own class?", new List<string>() { "public", "private", "protected", "internal" }, "private", "Easy"),
                new Question("What is polymorphism in OOP?", new List<string>() { "Ability to hide data", "Ability to inherit methods", "Ability to take many forms", "Ability to override constructors" }, "Ability to take many forms", "Medium")
            };
        }
    }
}
