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
                  new Question
                {
                    Number = 5,
                    SelectedAnswer = "C",
                    Text = "What does the following command primarily do?\n\ndotnet ef dbcontext scaffold \"ConnectionString\" Microsoft.EntityFrameworkCore.SqlServer -o Models",
                    Choices = new()
                    {
                        new Choice { Letter = "A", Text = "Deletes the database" },
                        new Choice { Letter = "B", Text = "Creates a new MVC project" },
                        new Choice { Letter = "C", Text = "Generates EF Core models and a DbContext from an existing database" },
                        new Choice { Letter = "D", Text = "Starts the MVC application" },
                    }
                },
                  new Question
                {
                    Number = 6,
                    SelectedAnswer = "B",
                    Text = "Where is a database connection string commonly stored in an ASP.NET Core MVC application?",
                    Choices = new()
                    {
                        new Choice { Letter = "A", Text = "Program.cs only" },
                        new Choice { Letter = "B", Text = "appsettings.json" },
                        new Choice { Letter = "C", Text = "Index.cshtml" },
                        new Choice { Letter = "D", Text = "Student.cs" },
                    }
                },
                  new Question
                {
                    Number = 7,
                    SelectedAnswer = "B",
                    Text = "A Student belongs to exactly one Section, while a Section can contain many students. What type of relationship is this?",
                    Choices = new()
                    {
                        new Choice { Letter = "A", Text = "One-to-One" },
                        new Choice { Letter = "B", Text = "One-to-Many" },
                        new Choice { Letter = "C", Text = "Many-to-Many" },
                        new Choice { Letter = "D", Text = "Many-to-One only" },
                    }
                },
                  new Question
                {
                    Number = 8,
                    SelectedAnswer = "B",
                    Text = "In the following example, what is SectionId?\n\npublic int SectionId { get; set; }\npublic Section Section { get; set; }",
                    Choices = new()
                    {
                        new Choice { Letter = "A", Text = "Primary key of Student" },
                        new Choice { Letter = "B", Text = "Foreign key referencing Section" },
                        new Choice { Letter = "C", Text = "Navigation property" },
                        new Choice { Letter = "D", Text = "Database connection string" },
                    }
                },
                  new Question
                {
                    Number = 9,
                    SelectedAnswer = "B",
                    Text = "What is the purpose of a navigation property such as public Section Section { get; set; }?",
                    Choices = new()
                    {
                        new Choice { Letter = "A", Text = "It stores the database password" },
                        new Choice { Letter = "B", Text = "It represents a relationship to another entity" },
                        new Choice { Letter = "C", Text = "It creates a new database" },
                        new Choice { Letter = "D", Text = "It validates the student's name" },
                    }
                },
                  new Question
                {
                    Number = 10,
                    SelectedAnswer = "B",
                    Text = "What does .Include() generally allow EF Core to do?",
                    Choices = new()
                    {
                        new Choice { Letter = "A", Text = "Delete the Section table" },
                        new Choice { Letter = "B", Text = "Load related Section data together with Students" },
                        new Choice { Letter = "C", Text = "Create a new Student" },
                        new Choice { Letter = "D", Text = "Validate Student input" },
                    }
                },
                  new Question
                {
                    Number = 11,
                    SelectedAnswer = "B",
                    Text = "Why might a ViewModel be used when displaying Student and Section information?",
                    Choices = new()
                    {
                        new Choice { Letter = "A", Text = "To replace the database" },
                        new Choice { Letter = "B", Text = "To combine or shape the data specifically needed by the view" },
                        new Choice { Letter = "C", Text = "To automatically create database tables" },
                        new Choice { Letter = "D", Text = "To prevent controllers from using LINQ" },
                    }
                },
                  new Question
                {
                    Number = 12,
                    SelectedAnswer = "A",
                    Text = "Consider this query:\n\nvar students = _context.Students.Include(s => s.Section).ToList();\n\nWhat is the main benefit of Include(s => s.Section)?",
                    Choices = new()
                    {
                        new Choice { Letter = "A", Text = "It loads the related Section navigation property" },
                        new Choice { Letter = "B", Text = "It creates a Section object manually" },
                        new Choice { Letter = "C", Text = "It removes the foreign key" },
                        new Choice { Letter = "D", Text = "It prevents the query from accessing the database" },
                    }
                },
                  new Question
                {
                    Number = 13,
                    SelectedAnswer = "B",
                    Text = "Which type of validation occurs in the browser before a request is sent to the server?",
                    Choices = new()
                    {
                        new Choice { Letter = "A", Text = "Database-level validation" },
                        new Choice { Letter = "B", Text = "Client-side validation" },
                        new Choice { Letter = "C", Text = "Server-side validation" },
                        new Choice { Letter = "D", Text = "EF Core migration validation" },
                    }
                },
                  new Question
                {
                    Number = 14,
                    SelectedAnswer = "A",
                    Text = "Why is server-side validation still necessary if client-side validation exists?",
                    Choices = new()
                    {
                        new Choice { Letter = "A", Text = "Client-side validation can be bypassed" },
                        new Choice { Letter = "B", Text = "Client-side validation automatically modifies the database" },
                        new Choice { Letter = "C", Text = "Server-side validation only works with SQLite" },
                        new Choice { Letter = "D", Text = "Client-side validation cannot display messages" },
                    }
                },
            };
        }
    }
}
