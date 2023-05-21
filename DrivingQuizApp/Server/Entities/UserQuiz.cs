using System.ComponentModel.DataAnnotations;

namespace DrivingQuizApp.Server.Entities;

public record UserQuiz()
{
    public int Id { get; init; }

    [Required]
    public DateTime DateTaken { get; init; } = DateTime.Now;

    public IEnumerable<UserQuizQuestion> Questions { get; init; } 
}