using IT_Elective_2_PreFinal_Exam.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExamApp.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Index()
        {
            var questions = ExamData.GetQuestions();

            var model = new ExamViewModel
            {
                ExamTitle = "IT Elective 2 Pre-Final Exam",
                TotalQuestions = questions.Count,
                Questions = questions
            };

            return View(model);
        }
    }
}
