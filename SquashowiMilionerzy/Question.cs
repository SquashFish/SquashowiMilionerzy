using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace SquashowiMilionerzy
{
    public class Question
    {
        public string QuestionText { get; set; }
        public string[] Answers { get; set; }
        public char CorrectAnswer { get; set; }
        private void PrintQuestion()// should be single responsibility
        {
            Console.WriteLine(QuestionText);
            foreach (string answer in Answers)

                Console.WriteLine(answer);
        }

        private bool CheckAnswer()
        {
            ConsoleReaderConverter reader = new ConsoleReaderConverter();

            char answer = reader.ReadChar();
            if (answer == char.ToLower(CorrectAnswer))
            {
                Console.WriteLine("To jest poprawana odpowiedź!");
                return true;
            }
            Console.WriteLine("To jest zła odpowiedź!");
            return false;
        }
        public bool AskQuestion()
        {
            PrintQuestion();
            return CheckAnswer(); //returns true or false 
        }
    }
}
