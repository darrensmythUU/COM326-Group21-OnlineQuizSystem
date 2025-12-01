using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuizSystemClassLibrary
{
    public class Question
    {
        // Private Fields
        private int questionID;
        private string questionText;
        private List<string> questionOptions;
        private string questionCorrectAnswer;
        private string questionDifficultyLevel;
        private static int count = 0;

        // Public Get/Set Constructors
        public int QuestionID
        {
            get { return questionID; }
        }

        public string QuestionText
        {
            get { return questionText; }
            set { questionText = value; }
        }

        public List<string> QuestionOptions
        {
            get { return questionOptions; }
            set { questionOptions = value; }
        }

        public string QuestionCorrectAnswer
        {
            get { return questionCorrectAnswer; }
            set { questionCorrectAnswer = value; }
        }

        public string QuestionDifficultyLevel
        {
            get { return questionDifficultyLevel; }
            set { questionDifficultyLevel = value; }
        }

        // Default Constructor for Question object
        public Question()
        {
            this.questionID = count;
            this.QuestionText = "";
            this.QuestionOptions = new List<string>();
            this.QuestionCorrectAnswer = "";
            this.QuestionDifficultyLevel = "";
            count++;
        }

        // Paramaterised Constructor for Question object
        public Question(string questionText, List<string> questionOptions, string questionCorrectAnswer, string questionDifficultyLevel)
        {
            this.questionID = count;
            this.QuestionText = questionText;
            this.QuestionOptions = questionOptions;
            this.QuestionCorrectAnswer = questionCorrectAnswer;
            this.QuestionDifficultyLevel = questionDifficultyLevel;
            count++;
        }

        // Methods
        public void DisplayInfo()
        {
            Console.WriteLine($"Question ID: {QuestionID}");
            Console.WriteLine($"Question Text: {QuestionText}");
            Console.WriteLine($"Question Correct Answer: {QuestionCorrectAnswer}");
            Console.WriteLine($"Question Difficulty Level: {QuestionDifficultyLevel}");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Question Options:");

            for (int i = 0; i < QuestionOptions.Count; i++)
            {
                Console.WriteLine($"{i} - {QuestionOptions[i]}.");
            }
            Console.WriteLine();
        }
    }
}
