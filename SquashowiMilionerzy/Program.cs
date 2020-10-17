using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

namespace SquashowiMilionerzy
{


    class Program
    {


    static void Main(string[] args)
        {
            var myJsonString = File.ReadAllText("myfile.json");
            //using(FileStream fs = File.OpenRead("Questions.json")) //here has to be used to open a Json file, but has many other uses
            //{
            //    loadedQuestions = JsonSerializer.Deserialize<List<LoadedQuestion>>(fs);
            //}

            List<Question> Questions500 = new List<Question>();
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

            Questions500.Add(new Question
            {
                QuestionText = "Ile setów musimy wygrać aby wygrać mecz best of 5?",
                Answers = new string[] { "a.3", "b.5", "c.1", "d.7" },
                CorrectAnswer = 'A'
            });

            Questions500.Add(new Question
            {
                QuestionText = "Kto nie jest zawodnikiem squasha?",
                Answers = new string[] { "a.Ronald Regan", "b.Nicol David", "c.Mohamed El Shorbagy", "d.Camille Serme" },
                CorrectAnswer = 'A',
            });

            Questions500.Add(new Question
            {
                QuestionText = "Ile kwadratów znajduje się na korcie do squasha?",
                Answers = new string[] { "a.1", "b.2", "c.3", "d.4" },
                CorrectAnswer = 'A'
            });


            List<Question> selectedQuestions = new List<Question>();
            Random dice = new Random(); // random number generator
            foreach (List<Question> questions in AllQuestions)
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
            Console.ReadKey();
        }

    }
}

