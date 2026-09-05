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
                },
                 new Question
                {
                    Number = 2,
                    SelectedAnswer = "B",
                    Text = "Which approach is being used when an existing database is used to generate EF Core entity classes?",
                    Choices = new()
                    {
                        new Choice { Letter = "A", Text = "Code-First" },
                        new Choice { Letter = "B", Text = "Database-First" },
                        new Choice { Letter = "C", Text = "Model-First" },
                        new Choice { Letter = "D", Text = "Controller-First" },
                    }
                },
                  new Question
                {
                    Number = 3,
                    SelectedAnswer = "C",
                    Text = "What is the primary purpose of Entity Framework Core?",
                    Choices = new()
                    {
                        new Choice { Letter = "A", Text = "To create HTML pages automatically" },
                        new Choice { Letter = "B", Text = "To replace the MVC Controller" },
                        new Choice { Letter = "C", Text = "To map objects in code to relational database data" },
                        new Choice { Letter = "D", Text = "To replace the C# compiler" },
                    }
                },
                  new Question
                {
                    Number = 4,
                    SelectedAnswer = "A",
                    Text = "Which EF Core component is primarily responsible for communicating with the database?",
                    Choices = new()
                    {
                        new Choice { Letter = "A", Text = "DbContext" },
                        new Choice { Letter = "B", Text = "DbSetView" },
                        new Choice { Letter = "C", Text = "ControllerContext" },
                        new Choice { Letter = "D", Text = "RazorContext" },
                    }
                },
            };
        }
    }
}
