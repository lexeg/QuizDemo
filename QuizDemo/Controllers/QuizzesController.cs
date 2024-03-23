using Microsoft.AspNetCore.Mvc;
using QuizDemo.Models;

namespace QuizDemo.Controllers;

[ApiController]
[Route("[controller]")]
public class QuizzesController : ControllerBase
{
    [HttpGet("first-test")]
    public Task<QuestionModel[]> GetFirstTest()
    {
        return new Task<QuestionModel[]>(() => new QuestionModel[]
        {
            new()
            {
                Text = "Вопрос 1",
                Answers = new[] { "Ответ 1", "Ответ 2", "Ответ 3", "Ответ 4" },
                CorrectAnswerId = 2
            },
            new()
            {
                Text = "Вопрос 2",
                Answers = new[] { "Ответ 1", "Ответ 2", "Ответ 3", "Ответ 4" },
                CorrectAnswerId = 2
            },
            new()
            {
                Text = "Вопрос 3",
                Answers = new[] { "Ответ 1", "Ответ 2", "Ответ 3", "Ответ 4" },
                CorrectAnswerId = 2
            },
            new()
            {
                Text = "Вопрос 4",
                Answers = new[] { "Ответ 1", "Ответ 2", "Ответ 3", "Ответ 4" },
                CorrectAnswerId = 2
            },
            new()
            {
                Text = "Вопрос 5",
                Answers = new[] { "Ответ 1", "Ответ 2", "Ответ 3", "Ответ 4" },
                CorrectAnswerId = 2
            }
        });
    }
}