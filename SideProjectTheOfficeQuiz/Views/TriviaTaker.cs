using SideProjectTheOfficeQuiz.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SideProjectTheOfficeQuiz.Views
{
    public class TriviaTaker
    {
        private Trivia quiz;

        public TriviaTaker(Trivia quiz)
        {
            if (quiz == null)
            {
                throw new NullReferenceException("You must pass a Quiz into QuizTaker");
            }
            this.quiz = quiz;
        }

        public void TakeQuiz(bool immediateFeedback)
        {
            Console.Clear();

            Console.WriteLine(quiz.Name);
            Console.WriteLine("Press ENTER to begin...");
            Console.ReadLine();

            int questionNumber = 1;
            foreach (Question question in quiz.Questions)
            {
                Console.Clear();
                Console.Write($"{questionNumber}) ");
                Console.WriteLine(question.QuestionToDisplay);

                bool validAnswer = false;
                while (!validAnswer)
                {
                    Console.Write(question.AnswerPrompt);
                    string input = Console.ReadLine();
                    validAnswer = question.ValidateAnswerAndSetResponse(input);
                }

                if (immediateFeedback == true)
                {
                    string feedback;
                    if (question.Correctness == 0.0)
                    {
                        feedback = $"Wrong! The correct answer is '{question.CorrectResponse}'.";
                    }
                    else if (question.Correctness < 1.0)
                    {
                        feedback = $"You almost got it!: {question.Correctness}. The correct answer is '{question.CorrectResponse}'.";
                    }
                    else
                    {
                        feedback = "Correct!";
                    }
                    Console.WriteLine(feedback);
                    Console.Write("Press enter to continue...");
                    Console.ReadLine();
                    questionNumber++;
                }
            }
            Console.WriteLine($"You have finished the Quiz. Your score was {Math.Round(quiz.Score)}%");
        }
    }
}
