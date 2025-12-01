using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuizSystemClassLibrary
{
    public class Category
    {
        // Private Fields
        private int id;
        private string name;
        private string description;
        private static int count = 0;

        // Public Get/Set Constructors
        public int ID
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        // Default Constructor for Category object
        public Category()
        {
            this.id = count;
            this.Name = "";
            this.Description = "";
            count++;
        }

        // Paramaterised Constructor for Category object
        public Category(string categoryName, string categoryDescription)
        {
            this.id = count;
            this.Name = categoryName;
            this.Description = categoryDescription;
            count++;
        }

        // Methods
        public void DisplayInfo()
        {
            Console.WriteLine($"Category ID: {ID}");
            Console.WriteLine($"Category Name: {Name}");
            Console.WriteLine($"Category Description: {Description}");
            Console.WriteLine();
        }
    }
}
