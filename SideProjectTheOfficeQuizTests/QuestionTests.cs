using Microsoft.VisualStudio.TestTools.UnitTesting;
using SideProjectTheOfficeQuiz.Models;

namespace SideProjectTheOfficeQuizTests
{
    [TestClass]
    public class QuestionTests
    {
        [DataTestMethod]
        [DataRow("y", true, 1.0)]
        [DataRow("Y", true, 1.0)]
        [DataRow("yes", true, 1.0)]
        [DataRow("ye", false, 0.0)]
        [DataRow("f", true, 0.0)]
        [DataRow("n", true, 0.0)]
        [DataRow("N", true, 0.0)]
        public void TrueFalseQuestionTest(string response, bool expectedIsValid, double expectedCorrectness)
        {
            Question question = new TrueFalseQuestions("A True Question", "true");

            // Question should be NOT complete
            Assert.IsFalse(question.IsComplete);

            bool isValid = question.ValidateAnswerAndSetResponse(response);

            Assert.AreEqual(expectedIsValid, isValid);

            if (isValid)
            {
                // Question should be correct (1.0) and Complete
                Assert.IsTrue(question.IsComplete);
                Assert.AreEqual(expectedCorrectness, question.Correctness);
            }
            else
            {
                // Question should not be Complete
                Assert.IsFalse(question.IsComplete);
            }
        }
    }
}
