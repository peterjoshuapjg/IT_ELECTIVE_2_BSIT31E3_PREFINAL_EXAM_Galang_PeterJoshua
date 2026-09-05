namespace IT_Elective_2_PreFinal_Exam.Models
{

    public class ExamViewModel
    {
        public string ExamTitle { get; set; } = "IT Elective 2 Pre-Final Exam";
        public int TotalQuestions { get; set; }
        public List<Question> Questions { get; set; } = new();
    }
}
