using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OnlineQuizSystemClassLibrary
{
    public class Quiz
    {
        // Private Fields
        private int id;
        private string quizTitle;
        private string quizDescription;
        private Category quizCategory;
        private List<Question> quizQuestions;
        private DateTime quizDate;
        private static int count = 0;

        // Public Get/Set Constructors
        public int ID
        {
            get { return id; }
        }

        public string QuizTitle
        {
            get { return quizTitle; }
            set { quizTitle = value; }
        }

        public string QuizDescription
        {
            get { return quizDescription; }
            set { quizDescription = value; }
        }

        public Category QuizCategory
        {
            get { return quizCategory; }
            set { quizCategory = value; }
        }

        public List<Question> QuizQuestions
        {
            get { return quizQuestions; }
            set { quizQuestions = value; }
        }

        public DateTime QuizDate
        {
            get { return quizDate; }
            set { quizDate = value; }
        }

        // Default Constructor for Quiz object
        public Quiz()
        {
            this.id = count;
            this.QuizTitle = "";
            this.QuizDescription = "";
            this.QuizCategory = new Category();
            this.QuizQuestions = new List<Question>();
            this.QuizDate = DateTime.Now;
            count++;
        }

        // Paramaterised Constructor for Quiz object
        public Quiz(string quizTitle, string quizDescription, Category quizCategory, List<Question> quizQuestions, DateTime quizDate)
        {
            this.id = count;
            this.QuizTitle = quizTitle;
            this.QuizDescription = quizDescription;
            this.QuizCategory = quizCategory;
            this.QuizQuestions = quizQuestions;
            this.QuizDate = quizDate;
            count++;
        }

        // Methods
        public void DisplayInfo()
        {
            Console.WriteLine($"Quiz ID: {ID}");
            Console.WriteLine($"Quiz Name: {QuizTitle}");
            Console.WriteLine($"Quiz Date: {QuizDate}");
            Console.WriteLine($"Quiz Category: {QuizCategory}");
            Console.WriteLine($"Quiz Description: {QuizDescription}");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Quiz Questions");

            for (int i = 0; i < QuizQuestions.Count; i++)
            {
                Console.WriteLine($"{i} - {QuizQuestions[i]}.");
            }
            Console.WriteLine();
        }
    }
}
