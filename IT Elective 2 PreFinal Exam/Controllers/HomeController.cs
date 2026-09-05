using Microsoft.AspNetCore.Mvc;

namespace ExamApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => RedirectToAction("Index", "Exam");

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() => View();
    }
}
