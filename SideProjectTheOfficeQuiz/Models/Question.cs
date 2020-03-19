using System;
using System.Collections.Generic;
using System.Text;

namespace SideProjectTheOfficeQuiz.Models
{
    abstract public class Question
    {
        public string QuestionText { get; }
        public string CorrectResponse { get; }
        public bool IsCaseSensitive { get; }

        virtual public string QuestionToDisplay
        {
            get
            {
                return QuestionText;
            }
        }

        private string responseText;
        public string ResponseText
        {
            get { return this.responseText; }
            set
            {
                if (!IsComplete)
                {
                    this.responseText = value;
                }
            }
        }
        public double Correctness { get; set; } // 0.0 to 1.0 scale to allow for partial credit
        public bool IsComplete { get; private set; }

        public Question(string questionText, string correctResponse, bool isCaseSensitive)
        {
            this.QuestionText = questionText;
            this.CorrectResponse = correctResponse;
            this.IsCaseSensitive = IsCaseSensitive;
            this.Correctness = 0.0;
            this.IsComplete = false;
        }

        virtual protected void GradeQuestion()
        {
            if (IsCaseSensitive)
            {
                Correctness = (ResponseText == CorrectResponse) ? 1.0 : 0.0;
            }
            else
            {
                Correctness = (ResponseText.ToLower() == CorrectResponse.ToLower()) ? 1.0 : 0.0;
            }
        }

        virtual public string AnswerPrompt
        {
            get
            {
                return "Answer: ";
            }
        }

        virtual public bool ValidateAnswerAndSetResponse(string answer)
        {
            ResponseText = answer;
            GradeQuestion();
            this.IsComplete = true;
            return true;
        }
    }
}
