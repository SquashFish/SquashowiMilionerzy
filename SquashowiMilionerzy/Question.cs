using System;
using System.Drawing;

namespace SquashowiMilionerzy
{
    public class Question
    {
        public int DifficultyLevel { get; set; }
        public string QuestionText { get; set; }
        public string[] Answers { get; set; }
        public char CorrectAnswer { get; set; }
        private void PrintQuestion()// should be single responsibility
        {
            Console.WriteLine($"Teraz pytanie za: { DifficultyLevel}PLN");
            Console.WriteLine(QuestionText);

            PrintColorfulAnswers(100,100);

        }
        private void PrintColorfulAnswers(int correctAnswer, int selectedAnswer)
        {
            for (int i = 0; i < Answers.Length; i++)
            {
                if (i == correctAnswer)
                {
                    Colorful.Console.WriteLine(Answers[i], Color.Green);
                }
                else if (i ==selectedAnswer)
                {
                    Colorful.Console.WriteLine(Answers[i], Color.Red);
                }
                else
                {
                    Colorful.Console.WriteLine(Answers[i]);
                }
            }
        }
        private int GetAnswerIndex(char letter)
        {
        
            if(char.ToLower (letter) == 'a')
            {
                return 0;
            }
            if (char.ToLower(letter) == 'b')
            {
                return 1;
            }
            if (char.ToLower(letter) == 'c')
            {
                return 2;
            }
            if (char.ToLower(letter) == 'd')
            {
                return 3;
            }
            return 999;
        }


        private bool CheckAnswer()
        {
            ConsoleReaderConverter reader = new ConsoleReaderConverter();

            char answer = reader.ReadChar();
            var indexNumber = GetAnswerIndex(answer);
            Console.SetCursorPosition(0, Console.CursorTop - 5);
            if (answer == char.ToLower(CorrectAnswer))
            {
                PrintColorfulAnswers(indexNumber,indexNumber);
                Colorful.Console.WriteLine("To jest poprawana odpowiedź!", Color.Green);
                return true;
            }
            var indexRight = GetAnswerIndex(CorrectAnswer);
            PrintColorfulAnswers(indexRight, indexNumber);
            Colorful.Console.WriteLine("To jest zła odpowiedź!",Color.Red);
            return false;
        }
        public bool AskQuestion()
        {
            PrintQuestion();
            return CheckAnswer(); //returns true or false 
        }
    }
}
