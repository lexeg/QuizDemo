namespace QuizDemo.Models;

public class QuestionModel
{
    public string Text { get; set; }

    public string[] Answers { get; set; }

    public int CorrectAnswerId { get; set; }
}