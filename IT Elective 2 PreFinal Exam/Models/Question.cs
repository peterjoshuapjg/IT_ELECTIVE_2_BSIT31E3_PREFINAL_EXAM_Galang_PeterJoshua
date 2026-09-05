namespace IT_Elective_2_PreFinal_Exam.Models
{

    public class Question
    {
        public int Number { get; set; }
        public string Text { get; set; } = string.Empty;
        public List<Choice> Choices { get; set; } = new();

        public string? SelectedAnswer { get; set; }
    }

    public class Choice
    {
        public string Letter { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
    }
}
