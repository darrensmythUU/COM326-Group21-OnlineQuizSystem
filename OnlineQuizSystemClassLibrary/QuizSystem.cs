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
    }
}
