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
        private int categoryID;
        private string categoryName;
        private string categoryDescription;
        private static int count = 0;

        // Public Get/Set Constructors
        public int ID
        {
            get { return categoryID; }
        }

        public string CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; }
        }

        public string CategoryDescription
        {
            get { return categoryDescription; }
            set { categoryDescription = value; }
        }

        // Default Constructor for Category object
        public Category()
        {
            this.categoryID = count;
            this.CategoryName = "";
            this.CategoryDescription = "";
            count++;
        }

        // Paramaterised Constructor for Category object
        public Category(string categoryName, string categoryDescription)
        {
            this.categoryID = count;
            this.CategoryName = categoryName;
            this.CategoryDescription = categoryDescription;
            count++;
        }

        // Methods
        public void DisplayInfo()
        {
            Console.WriteLine($"Category ID: {ID}");
            Console.WriteLine($"Category Name: {CategoryName}");
            Console.WriteLine($"Category Description: {CategoryDescription}");
            Console.WriteLine();
        }
    }
}
