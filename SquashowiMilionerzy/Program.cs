using System;
using System.Collections.Generic;

namespace SquashowiMilionerzy
{

    
    class Program
    {
        public static string[] pytania500 = new string[5];

        static void Main(string[] args)
        {
            //            char[] odpowiedzi500 = new char[5]; //inicjalizuje tablice char'ów odpowiedzi na pytania za 500 zł
            //            pytania500[0] = @"Do ilu punktów grany jest jeden set w squashu? 
            //a. 15 b. 12 c. 11 d. 21";
            //            odpowiedzi500[0] = 'C';
            //            pytania500[1] = @"Ile setów musimy wygrać aby wygrać mecz best of 5?
            //a. 3 b. 5 c.1 d.7";
            //            odpowiedzi500[1] = 'A';
            //            pytania500[2] = @"Kto nie jest zawodnikiem squasha?
            //a. Ronald Regan b. Nicol David c. Mohamed El Shorbagy d.Camille Serme";
            //            odpowiedzi500[2] = 'A';
            //            pytania500[3] = @"Ile kwadratów znajduje się na korcie do squasha?
            //a. 1 b. 2 c. 3 d. 4";
            //            odpowiedzi500[3] = 'B';
            //            pytania500[4] = @"Jaką piłką rozgrywa się profesjonalne mecze?
            //a. z 1 czerwoną kropką b. z 1 niebieską kropką c. z 2 żółtymi kropkami d. z 1 żółtą kropką";
            //            odpowiedzi500[4] = 'C';


            //            Console.WriteLine("PYTANIE ZA 500ZŁ WPISZ: A, B, C LUB D I WCIŚNIJ ENTER:");
            //            Console.WriteLine(pytania500[0]);
            Question Question1 = new Question();
            Question1.QuestionText = "Do ilu punktów grany jest jeden set w squashu?";
            Question1.Answers = new string[] { "a. 15", "b. 12", "c. 11", "d. 21" };
            Question1.CorrectAnswer = 'C';

            List<Question> Questions500 = new List<Question> { Question1 };
            List<Question> Questions1000 = new List<Question>();
            List<Question> Questions2000 = new List<Question>();
            List<Question> Questions10000 = new List<Question>();
            List<Question> Questions20000 = new List<Question>();
            List<Question> Questions40000 = new List<Question>();

            List<List<Question>> AllQuestions = new List<List<Question>>
            {
                Questions500,
                Questions1000,
                Questions2000,
                Questions10000,
                Questions20000,
                Questions40000
            };

            List<Question> selectedQuestions = new List<Question>();
            Random dice = new Random(); // random number generator
            foreach (List<Question>questions in AllQuestions)
            {
                int i = dice.Next(questions.Count); // int i variable to represent a random number
                selectedQuestions.Add(questions[i]); // addition of a question from AllQuestions to selectedQuestions
            }
            bool result = true;
            foreach (Question question in selectedQuestions)
            {
                if (result == true)
                {
                    question.AskQuestion();
                }
                else
                {
                    Console.WriteLine("G A M E O V E R");
                    break;
                }
            }
            





            Question1.AskQuestion();
            Console.ReadKey();







        }

    }
}

