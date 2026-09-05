using Microsoft.AspNetCore.Mvc;

namespace IT_Elective_2_PreFinal_Exam.Models
{

    public static class ExamData
    {
        public static List<Question> GetQuestions()
        {
            return new List<Question>
            {
                new Question
                {
                    Number = 1,
                    SelectedAnswer = "C",
                    Text = "What is the main problem solved by using a database instead of an in-memory collection?",
                    Choices = new()
                    {
                        new Choice { Letter = "A", Text = "It makes C# code shorter" },
                        new Choice { Letter = "B", Text = "It prevents the application from restarting" },
                        new Choice { Letter = "C", Text = "It allows data to persist after the application stops" },
                        new Choice { Letter = "D", Text = "It removes the need for MVC" },
                    }
                }
            };
        }
    }
}
