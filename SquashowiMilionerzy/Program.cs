
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace SquashowiMilionerzy
{
    class Program
    {
        static void Main(string[] args)
        {
            const string Intro = @"WITAJ W SQUASHOWYCH MILIONERACH
MASZ SZANSĘ PRZETESTOWAĆ SWOJĄ WIEDZE NA TEMAT SQUASHA
PODAJ JEDNĄ PRAWIDŁOWĄ ODPOWIEDŹ SPOŚRÓD CZTERACH OPCJI: A, B, C i D
POWODZENIA";

            Console.WriteLine(Intro);

            var myJsonString = File.ReadAllText("SquashQuestions.json");
            var AllQuestions = JsonSerializer.Deserialize<List<List<Question>>>(myJsonString);
            var selectedQuestions = new List<Question>();
            var dice = new Random(); // random number generator

            foreach (var questions in AllQuestions)
            {
                var i = dice.Next(questions.Count); // int i variable to represent a random number
                selectedQuestions.Add(questions[i]); // addition of a question from AllQuestions to selectedQuestions
            }

            var result = true;

            foreach (var question in selectedQuestions)
            {
                if (result == true)
                {
                    result = question.AskQuestion();
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

