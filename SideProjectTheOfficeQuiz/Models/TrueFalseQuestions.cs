using System;
using System.Collections.Generic;
using System.Text;

namespace SideProjectTheOfficeQuiz.Models
{
    public class TrueFalseQuestions : Question
    {
        public TrueFalseQuestions(string questionText, string correctResponse) : base(questionText, correctResponse, false)
        {

        }

        override public string AnswerPrompt
        {
            get
            {
                return "Answer (true of false): ";
            }
        }

        override public bool ValidateAnswerAndSetResponse(string answer)
        {
            switch (answer.ToLower())
            {
                case "y":
                case "t":
                case "yes":
                case "true":
                    answer = "true";
                    break;
                case "n":
                case "no":
                case "f":
                case "false":
                    answer = "false";
                    break;
                default:
                    return false;
            }
            base.ValidateAnswerAndSetResponse(answer);
            return true;
        }
    }
}
