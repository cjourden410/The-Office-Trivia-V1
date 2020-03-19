using SideProjectTheOfficeQuiz.Models;
using SideProjectTheOfficeQuiz.Views;
using System;
using System.Collections.Generic;

namespace SideProjectTheOfficeQuiz
{
    public class Program
    {
        private static Dictionary<Trivia, double?> quizzes = new Dictionary<Trivia, double?>()
        {
            { TriviaOptions.DunderMifflin, null},
            { TriviaOptions.RegionalManagers, null},
            { TriviaOptions.Sales, null},
            { TriviaOptions.TheAnnex, null},
            { TriviaOptions.Corporate, null},
        };


        static void Main(string[] args)
        {
            SelectAQuiz();

            Console.WriteLine();
            Console.WriteLine("Thanks for playing - Please come back to Scranton, PA soon!");
            Console.ReadLine();
        }

        static void SelectAQuiz()
        {
            // Loop until the user is done
            bool quit = false;

            while (!quit)
            {
                Console.Clear();

                // Print heading

                // Show the user the list of quizzes
                //Print each quiz
                Dictionary<int, Trivia> choices = new Dictionary<int, Trivia>();
                int choice = 1;
                Console.WriteLine(" _____ _            _____  __  __ _            _____    _       _       ");
                Console.WriteLine("|_   _| |          |  _  |/ _|/ _(_)          |_   _|  (_)     (_)      ");
                Console.WriteLine("  | | | |__   ___  | | | | |_| |_ _  ___ ___    | |_ __ ___   ___  __ _ ");
                Console.WriteLine("  | | | '_ \\ / _ \\ | | | |  _|  _| |/ __/ _ \\   | | '__| \\ \\ / / |/ _` |");
                Console.WriteLine("  | | | | | |  __/ \\ \\_/ / | | | | | (_|  __/   | | |  | |\\ V /| | (_| |");
                Console.WriteLine("  \\_/ |_| |_|\\___|  \\___/|_| |_| |_|\\___\\___|   \\_/_|  |_| \\_/ |_|\\__,_|");
                Console.WriteLine();
                //Console.WriteLine($"{"Options",10}{"Score",44}");
                //Console.WriteLine("=========================================================");
                Console.WriteLine($"{"Options",18}{"Score",43}"); // Have 3 equals signs on each side
                Console.WriteLine($"{"========================================================",64}"); // This indentation is good
                foreach (KeyValuePair<Trivia, double?> kvp in quizzes)
                {
                    Trivia quiz = kvp.Key;
                    choices.Add(choice, quiz);
                    string scoreString = "---";
                    double? score = kvp.Value;
                    if (score.HasValue)
                    {
                        scoreString = $"{Math.Round(score.Value)}%";
                    }
                    Console.WriteLine($"{choice,13}) {quiz.Name,-40} {scoreString,5}");
                    choice++;

                }

                // Allow user to select one to take
                bool validSelection = false;
                int selection = 0;
                while (!validSelection)
                {
                    Console.WriteLine();
                    Console.Write("Select a subject (Q to quit): ");
                    string input = Console.ReadLine().ToLower();

                    if (input.StartsWith("q"))
                    {
                        quit = true;
                        return;
                    }
                    if (!int.TryParse(input, out selection))
                    {
                        // try again
                        continue;
                    }
                    if (!choices.ContainsKey(selection))
                    {
                        continue;
                    }
                    validSelection = true;

                }
                // Ok, take the quiz
                Trivia quizToTake = choices[selection];
                TriviaTaker quizTaker = new TriviaTaker(quizToTake);
                quizTaker.TakeQuiz(true);
                // Record the score
                quizzes[quizToTake] = quizToTake.Score;

                Console.ReadLine();
            }
        }
    }
}
