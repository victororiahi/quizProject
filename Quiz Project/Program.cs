using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Project
{
    class Program
    {
        private static void Main()
        {
            Console.WriteLine("Welcome to Victor's Final Quiz!");

            
            // Questions and Answers
            Dictionary<string, string> questionsAndAnswers = new Dictionary<string, string>()
        {
            {"What is the capital of France?", "Paris"},
            {"Who wrote 'Romeo and Juliet'?", "William Shakespeare"},
            {"What is the chemical symbol for water?", "H2O"},
            {"What year did the Titanic sink?", "1912"},
            {"Who painted the Mona Lisa?", "Leonardo da Vinci"}
        };

            int score = 0;


            // Iterate through questions
            foreach (var questionAndAnswer in questionsAndAnswers)
            {
                Console.WriteLine("\n" + questionAndAnswer.Key);
                Console.WriteLine("Your Answer:");
                string userAnswer = Console.ReadLine();


                if (userAnswer.ToLower() == questionAndAnswer.Value.ToLower())
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect! Game Over.");
                    break;
                }
            }


            Console.WriteLine($"\nYour total score is: {score}/{questionsAndAnswers.Count}");
        }
    }

}
