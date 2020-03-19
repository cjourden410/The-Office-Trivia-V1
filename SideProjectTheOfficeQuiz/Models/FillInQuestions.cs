using System;
using System.Collections.Generic;
using System.Text;

namespace SideProjectTheOfficeQuiz.Models
{
    public class FillInQuestions : Question
    {
        public bool TrimResponse { get; set; }
        public FillInQuestions(string questionText, string correctResponse, bool isCaseSensitive, bool trimResponse) : base(questionText, correctResponse, isCaseSensitive)
        {
            this.TrimResponse = trimResponse;
        }

        override public bool ValidateAnswerAndSetResponse(string answer)
        {
            if (TrimResponse)
            {
                answer = answer.Trim();
            }
            return base.ValidateAnswerAndSetResponse(answer);
        }
    }
}
